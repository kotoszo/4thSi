using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDumping
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.dll";

            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            Assembly assembly = Assembly.LoadFrom(path);
            Console.WriteLine(assembly.FullName);
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
                var members = type.GetMembers(flags);

                foreach (var member in members)
                {
                    Console.WriteLine(member.MemberType + " - " + member.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
