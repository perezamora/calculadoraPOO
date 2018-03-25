using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadatos
{
    // AttributeUsageAttribute:
    // AttributeTargets: Donde se puede aplicar el atributo
    // Inherited: Si puede heredarse o no a traves de las clases
    // AllowMultiple: Si puede exister mas de una instancia del atributo en un elemento

    [System.AttributeUsage(System.AttributeTargets.All)
    ]
    public class Author : Attribute
    {
        private string name;
        public double version;

        public Author(string name)
        {
            this.name = name;
            version = 1.0;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
