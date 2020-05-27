using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Connect();
        [OperationContract]
        void Diconnect();
        [OperationContract]
        string[] SearchFile();
        [OperationContract]
        string SearchFolder();
        [OperationContract]
        void MovePhoto(string source,string destination);
        [OperationContract]
        void Insert(string[] dbInfo);
        [OperationContract]
        int InsertFolder(string dbInfo);
        [OperationContract]
        int InsertPhoto(string[] dbInfo);
        [OperationContract]
        string[][] GetDatabaseInfo();
    }

 
}
