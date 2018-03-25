using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadatos
{
    [Developer("John Doe", "1")]
    [Author("Mala Rodriguez")]
    class Program
    {
        static void Main(string[] args)
        {
            GetAttribute(typeof(Program));
            Console.ReadKey();
        }


        public static void GetAttribute(Type t)
        {
            // Get instance of the attribute.
            DeveloperAttribute Attrib = (DeveloperAttribute)Attribute.GetCustomAttribute(t, typeof(DeveloperAttribute));
            Author Attrib1 = (Author)Attribute.GetCustomAttribute(t, typeof(Author));

            if (Attrib == null)
            {
                Console.WriteLine("The attribute was not found.");
            }
            else
            {
                // Get the Name value.
                Console.WriteLine("The Name Attribute is: {0}.", Attrib.Name);
                // Get the Level value.
                Console.WriteLine("The Level Attribute is: {0}.", Attrib.Level);
                // Get the Reviewed value.
                Console.WriteLine("The Reviewed Attribute is: {0}.", Attrib.Reviewed);
            }

            // Metadato Author
            if (Attrib1 == null)
            {
                Console.WriteLine("The attribute 1 was not found.");
            }
            else
            {
                Console.WriteLine("The Name Author is {0}. ", Attrib1.Name);
            }
        }
    }
}
