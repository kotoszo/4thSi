using System;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.dll";
            Assembly a = Assembly.LoadFile(path);
            ShowAssembly(a);

            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(ourAssembly);

            Console.ReadKey();
        }

        static void ShowAssembly(Assembly assembly)
        {
            string text = string.Format("Name:{0}\nGlobalAssemblyCache:{1}" +
                "Location:{2}\nImageRuntimeVersion:{3}\n",
                assembly.FullName, assembly.GlobalAssemblyCache, assembly.Location, assembly.ImageRuntimeVersion);
            Console.WriteLine(text);
            foreach (var item in assembly.Modules)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}
