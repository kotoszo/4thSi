using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyName theName = new AssemblyName
            {
                Name = "DemoAssembly",
                Version = new Version("1.0.0.0"),
            };
            AppDomain domain = AppDomain.CurrentDomain;

            AssemblyBuilder assemblyBuilder = domain.DefineDynamicAssembly(theName, AssemblyBuilderAccess.ReflectionOnly);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("CodeModule", "DemoAssembly.dll");
            TypeBuilder typeBuilder = moduleBuilder.DefineType("Animal", TypeAttributes.Public);

            Type animal = typeBuilder.CreateType();
            Console.WriteLine(animal.FullName);

            foreach (var item in animal.GetMembers())
            {
                Console.WriteLine(item.MemberType + " " + item.Name);
            }
            Console.ReadKey();
        }
    }
}
