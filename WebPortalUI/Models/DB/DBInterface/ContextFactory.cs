using System;
using System.Configuration;

namespace WebPortalUI.Models.DB
{
    public class ContextFactory : IContextFactory
    {
        public IContext<T> Instance<T>() where T : class, new()
        {
            ConnectionStringAttribute csAttr = Attribute.GetCustomAttribute(typeof(T), typeof(ConnectionStringAttribute)) as ConnectionStringAttribute;
            string key = (csAttr ?? ConnectionStringAttribute.Default).ConnectionString;
            string connectionString = ConfigurationHelper.GetConnectionString(key);
            IContext<T> returnContext = new Context<T>(connectionString);

            return returnContext;
        }

        public IUserContext UserContextInstance()
        {
            throw new System.NotImplementedException();
        }
    }
    public static class ConfigurationHelper
    {
        public static string GetConnectionString(string key)
        {
            string ConfigurationValue = string.Empty;

            if (!string.IsNullOrEmpty(key))
            {
                //TODO : Read Configuration from Cache

                //Try reading configuration from appsetting
                if (ConfigurationValue == string.Empty)
                {
                    try
                    {
                        ConfigurationValue = ConfigurationManager.ConnectionStrings[key].ConnectionString ?? string.Empty;
                    }
                    catch (Exception)
                    {
                        ConfigurationValue = string.Empty;
                    }
                }//end if read appsetting

                //Try reading configuration from Database
                if (ConfigurationValue == string.Empty)
                {
                    try
                    {
                        //TODO:
                        //read from database configuration
                    }
                    catch (Exception)
                    {
                        ConfigurationValue = string.Empty;
                    }
                }//end if db read

            }//end empty string check

            return ConfigurationValue;
        }
    }
}