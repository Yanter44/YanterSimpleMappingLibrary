using SimpleLibraryTestTwo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryTestTwo
{
    public class AutoMapBuilder : IYanterMapper 
    {
          
        public TRequest2 AutoMap<TRequest, TRequest2>(TRequest obj1, TRequest2 obj2)
        {
            Type type1 = typeof(TRequest);
            Type type2 = typeof(TRequest2);

            PropertyInfo[] properties1 = type1.GetProperties();
            PropertyInfo[] properties2 = type2.GetProperties();

            DynamicProperties dynamicProperties = new DynamicProperties();

            foreach (PropertyInfo property1 in properties1)
            {
                foreach (PropertyInfo property2 in properties2)
                {
                    if (property1.Name == property2.Name && property1.PropertyType == property2.PropertyType)
                    {
                        object value = property1.GetValue(obj1);
                        dynamicProperties.SetProperty(property2.Name, value);
                    }
                }
            }
            return dynamicProperties.GetOurClass<TRequest2>();
        }
        public TRequest2 CreateMap<TRequest, TRequest2>(TRequest obj1, TRequest2 obj2, MappingConfiguration<TRequest, TRequest2> config)
        {

            config.ApplyMappings(obj1, obj2);
            return obj2;
        }
    }
}
