using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AM_Client
{
    /// <summary>
    /// This class is to be used to store global
    /// </summary>
    public class AMClient
    {
        private static AMClient Client { get; set; }

        /// <summary>
        /// Private Constructor to allow only one instance of the class
        /// </summary>
        private AMClient()
        {
            
        }

        public static AMClient GetInstance()
        {
            if (Client == null)
            {
                Client = new AMClient();
            }

            return Client;
        }

        public T GetProperty<T>(string key)
        {
            if (Application.Current.Properties.Contains(key))
            {
                return (T) Application.Current.Properties[key];
            }
            else
            {
                return default(T);
            }
        }

        public bool SetProperty<T>(string key, T value)
        {
            if (!Application.Current.Properties.Contains(key))
            {
                Application.Current.Properties.Add(key, value);
                return true;
            }
            else
            {
                Application.Current.Properties[key] = value;
                return true;

            }
        }
    }
}
