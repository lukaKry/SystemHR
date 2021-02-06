using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer
{
    public enum ConnectionTypes { Sql, Text };


    public static class GlobalConfig
    {
        public static ConnectionTypes CnnType 
        {
            get
            {
                string configValue = ConfigurationManager.AppSettings["ConnectionTypes"];
                ConnectionTypes value = (ConnectionTypes)Enum.Parse(typeof(ConnectionTypes), configValue);
                return value;
            } 
        }

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(ConnectionTypes connectionTypes)
        {
            switch (connectionTypes)
            {
                case ConnectionTypes.Sql:
                    Connection = new SqlConnector();
                    break;

                case ConnectionTypes.Text:
                    Connection = new TextConnector();
                    break;
            }
        }
    }
}
