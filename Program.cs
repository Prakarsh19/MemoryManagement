using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            fileReader.Reader();
            Console.ReadLine();
        }
    }
    
}
