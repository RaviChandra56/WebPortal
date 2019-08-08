using System;

namespace WebPortalUI.Models.DB
{
    public class ConnectionStringAttribute : Attribute
    {
        public string ConnectionString { get; set; }
        public static ConnectionStringAttribute Default = new ConnectionStringAttribute(Constants.ConnectionString);
        public ConnectionStringAttribute(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}