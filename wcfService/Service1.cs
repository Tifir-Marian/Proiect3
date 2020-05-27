using System;
using System.Activities;
using System.Activities.Statements;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace wcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=WINDOWS-G851JRV\SQLEXPRESS;Initial Catalog=MyPhotos;Integrated Security=True");
        public void Connect()
        {
            sqlCon.Open();
        }

        public void MovePhoto(string source, string destination)
        {
            try
            {
                if (!System.IO.File.Exists(destination))
                {
                    File.Move(source, destination);
                    MessageBox.Show("File moved to " + destination);
                }
                else
                {
                    MessageBox.Show("File already saved there!");
                }    
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Diconnect()
        {
            sqlCon.Close();
        }

        public void Insert(string[] dbInfo)
        {
            String location = dbInfo[0];//LocationString.Text;
            String path = dbInfo[2];//PathString.Text;
            String name = dbInfo[4];//NameString.Text;
            int guidPhoto = InsertPhoto(dbInfo);
            int guidFolder = InsertFolder(location);
            Connect();
            SqlCommand sqlCmd;
            String query;
            query = "Select id from MyPhotos.dbo.PhotoPlacements where Photo_ID=@pid and Folder_ID=@fid";
            sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.AddWithValue("@pid", guidPhoto);
            sqlCmd.Parameters.AddWithValue("@fid", guidFolder);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                Diconnect();
            }
            else
            {
                Diconnect();
                Connect();
                query = "Insert into MyPhotos.dbo.PhotoPlacements(Photo_ID,Folder_ID)VALUES" +
                "( '" + guidPhoto.ToString() + "','" + guidFolder.ToString() + "')";
                sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();
                Diconnect();
            }
            MovePhoto(Path.Combine(path,name), Path.Combine(location,name));

        }

        public string[] SearchFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string[] databaseInfo = new string[3];
            Thread t = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "F:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    databaseInfo[0] = filePath.Substring(0, filePath.LastIndexOf("\\"));
                    databaseInfo[1] = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    FileInfo fi = null;
                    try
                    {
                        fi = new FileInfo(filePath);
                        databaseInfo[2] = fi.CreationTime.ToString();

                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            
            return databaseInfo;
        }

        public string SearchFolder()
        {
            string Path = "";
            Thread t = new Thread((ThreadStart)(() =>
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Path = fbd.SelectedPath;
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            return Path;
        }

        public int InsertFolder(string info)
        {
            Connect();
            SqlCommand sqlCmd;
            String query;
            int num = 0;
            query = "Select id from MyPhotos.dbo.Folders where Name=@name";
            sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.AddWithValue("@name", info);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            
            if (reader.Read())
            {
                num = (int)reader["id"];
                Diconnect();
            }
            else
            {
                Diconnect();
                Connect();
                Random random = new Random();
                num = random.Next();
                query = "Insert into MyPhotos.dbo.Folders (Name,CreationDate)VALUES" +
                "( '" + info + "','" + Directory.GetCreationTime(info) + "')";
                sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.ExecuteNonQuery();
                Diconnect();
            }           
            return num;
        }

        public int InsertPhoto(string[] dbInfo)
        {
            Connect();
            SqlCommand sqlCmd;
            Random random = new Random();
            int num = random.Next();
            String location = dbInfo[0];//LocationString.Text;
            String typeOfPhoto = dbInfo[1];//TypeOfPhotoString.Text;
            String path = dbInfo[2];//PathString.Text;
            String creationDate = dbInfo[3];//CreationDateString.Text;
            String name = dbInfo[4];//NameString.Text;
            String query = "Insert into MyPhotos.dbo.Photos (Id,CreationDate, TypeOfPhoto, Location , Path, Name)VALUES" +
                "( '" + num + "','" + creationDate + "','" + typeOfPhoto + "','" + location + "','" + path + "','" + name + "')";
            sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.ExecuteNonQuery();
            Diconnect();
            return num;
        }

        public string[][] GetDatabaseInfo()
        {
            Connect();
            SqlCommand sqlCmd;
            String query,path,name,location,typeofphoto;
            query = "Select * from MyPhotos.dbo.Photos";
            sqlCmd = new SqlCommand(query, sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            string[][] databaseInfo = new string[4][];
            int i = 0;
            while(reader.Read())
            {
                typeofphoto = reader["TypeOfPHoto"].ToString();
                location = reader["Location"].ToString();
                name = reader["Name"].ToString();
                path = reader["Path"].ToString();

                databaseInfo[0][i] = path;
                databaseInfo[1][i] = location;
                databaseInfo[2][i] = name;
                databaseInfo[3][i] = typeofphoto;
                i++;
            }
            Diconnect();
            return databaseInfo;
        }
    }
}
