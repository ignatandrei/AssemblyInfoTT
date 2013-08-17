using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EncryptionLibrary;
using MathLibrary;

namespace VeryBigProjectDOS
{
    class Program
    {
        static void Main(string[] args)
        {
            var a=new AddNumbers();
            var x= a.Add(1970,4,16);
            var en = new EncryptString();
            var c = en.Encrypt("http://msprogrammer.serviciipeweb.ro/");
            Console.WriteLine(en.Encrypt(c));

            var thisAssembly = Assembly.GetExecutingAssembly();
            string pathAss = Path.GetDirectoryName(thisAssembly.Location);
            var assemblies = thisAssembly.GetReferencedAssemblies();
            foreach (var assembly in assemblies)
            {
                
                var ass = Assembly.Load(assembly.FullName);

                if (Path.GetDirectoryName(ass.Location) != pathAss)
                    continue;

                Console.WriteLine("-------------------");
                Console.WriteLine(assembly.Name + ":" + assembly.Version);
                
                //Console.WriteLine(assembly.Name + assembly.Version);
            }

        }
    }
}
