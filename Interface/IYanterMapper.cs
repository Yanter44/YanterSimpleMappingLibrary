using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryTestTwo.Interface
{
    internal interface IYanterMapper
    {
        TRequest2 AutoMap<TRequest, TRequest2>(TRequest obj1, TRequest2 obj2);
        TRequest2 CreateMap<TRequest, TRequest2>(TRequest obj1, TRequest2 obj2, MappingConfiguration<TRequest, TRequest2> config);
    }
}

