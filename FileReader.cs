using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class FileReader:IDisposable
    {
        StreamReader sr = null;
        private bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Reader()
        {
            try
            {
                sr = new StreamReader("C:\\Users\\Prakarsh_Srivastava\\OneDrive - EPAM\\MemoryManagement\\Sample.txt");
                
                string line;
                    
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Dispose();
                Console.WriteLine("Disposed");
            }
        }
        public virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                //objSafeHandle.Dispose();
                Console.WriteLine("Clean up all managed objs and child also that implements ");
            }


            Console.WriteLine("Clean up all unmanaged..");
            sr.Close();

            _disposed = true;
        }
        ~FileReader()
        {
            Dispose(false);
        }
    }
}
