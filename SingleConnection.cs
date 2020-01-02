using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Export
{
    public class SingleConnection
    {                
        
        private static SingleConnection _ConsString = null;
        private String _String = null;
        private static readonly string dataSource;
        private static readonly string initialCatalog;
        private static readonly string userID;
        private static readonly string password;
        private SingleConnection() { }       

        public static string ConString
        {
            get
            {
                if (_ConsString == null)
                {
                    _ConsString = new SingleConnection { _String = SingleConnection.Connect(dataSource, initialCatalog, userID, password) };
                    return _ConsString._String;
                }
                else
                    return _ConsString._String;
            }
        }

        public static string Connect(string dataSource, string initialCatalog, string userID, string password)
        {
            //Build an SQL connection string
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource.ToString(), // Server name
                InitialCatalog = initialCatalog,  //Database
                UserID = userID,         //Username
                Password = password,  //Password
            };

            //Build an Entity Framework connection string
            //EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
            //{
            //    Provider = "System.Data.SqlClient",
            //    Metadata = "res://*/ShopModel.csdl|res://*/ShopModel.ssdl|res://*/ShopModel.msl",
            //    ProviderConnectionString = @"data source=" + dataSource + @";initial catalog=" + initialCatalog + @";user id=" + userID + @";password=" + password + @";"// sqlString.ToString()
            //};
            return sqlString.ConnectionString;
        }
    }
}
