﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.Web.dll";

            Assembly assembly = Assembly.LoadFile(path);
            Type type = assembly.GetType("System.Web.HttpUtility");

            var encode = type.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            var decode = type.GetMethod("HtmlDecode", new Type[] { typeof(string) });

            // Create a string to be encoded
            string originalString = "This is Sally & Jack's Anniversary <sic>";

            Console.WriteLine(originalString);

            // encode it and show the encoded value
            string encoded = (string)encode.Invoke(null, new object[] { originalString });

            Console.WriteLine(encoded);
            string decoded = (string)decode.Invoke(null, new object[] { encoded });
            Console.WriteLine(decoded);

            Console.ReadKey();
        }
    }
}
