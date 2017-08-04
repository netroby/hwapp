using System;
using System.Net;
using System.IO;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What your name");
            if (args == null || args.Length == 0) 
            {
                throw new ApplicationException("Specifiy the URL of the resource to retrieve");
            }

            WebClient client = new WebClient();
            
            Stream data = client.OpenRead(args[0]);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);
            data.Close();
            reader.Close();
        }
    }
}
