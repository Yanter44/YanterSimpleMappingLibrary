using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryTestTwo
{
    public class DynamicProperties
    {
        private Dictionary<string, object> properties = new Dictionary<string, object>();

        public void SetProperty(string propertyName, object value)
        {
            if (properties.ContainsKey(propertyName))
            {
                properties[propertyName] = value;
            }
            else
            {
                properties.Add(propertyName, value);
            }
        }
        public T GetOurClass<T>()
        {
            T ourclass = Activator.CreateInstance<T>();

            foreach (var prop in ourclass.GetType().GetProperties())
            {
                if (properties.ContainsKey(prop.Name))
                {
                    object value = properties[prop.Name];
                    prop.SetValue(ourclass, value);
                }
            }

            return ourclass;
        }
    }
}
