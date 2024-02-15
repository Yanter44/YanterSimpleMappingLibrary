using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryTestTwo
{
    public  class MappingConfiguration<TSource, TDestination>
    {
        private List<Action<TSource, TDestination>> mappings = new List<Action<TSource, TDestination>>();
        public void CreateMapConfig(Action<TSource, TDestination> mapping)
        {
            mappings.Add(mapping);
        }

        internal void ApplyMappings(TSource source, TDestination destination)
        {
            foreach (var mapping in mappings)
            {
                mapping(source, destination);
            }
        }
    }
}
