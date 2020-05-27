using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Interface
{
    public partial class GUI : Form
    {
        //SqlConnection sqlCon = new SqlConnection(@"Data Source=WINDOWS-G851JRV\SQLEXPRESS;Initial Catalog=MyPhotos;Integrated Security=True");
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public GUI()
        {
            InitializeComponent();
        }

        private void PathLabel_Click(object sender, EventArgs e)
        {

        }

        private void TypeOfPhotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void PathString_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocationString_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocationLabel_Click(object sender, EventArgs e)
        {

        }

        private void TypeOfPhotoString_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreationDateString_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatinoDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string[] receivedInfo = client.SearchFile();
            PathString.Text = receivedInfo[0];
            NameString.Text = receivedInfo[1];
            CreationDateString.Text = receivedInfo[2];
        }

        private void AddToButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select folder for the image to be put" }) ;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string[] infoToBeSend = new string[5];
            try
            {
                infoToBeSend[0] = LocationString.Text;
                infoToBeSend[1] = TypeOfPhotoString.Text;
                infoToBeSend[2] = PathString.Text;
                infoToBeSend[3] = CreationDateString.Text;
                infoToBeSend[4] = NameString.Text;
                client.Insert(infoToBeSend);
            }
            catch(Exception ex)
            {
                client.Diconnect();
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void NameString_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocationString.Text = client.SearchFolder();

        }
    }
}
