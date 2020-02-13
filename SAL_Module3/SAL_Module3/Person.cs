using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SAL_Module3
{
    public abstract class Person : IDisposable
    {
        private bool disposedValue = false; // To detect redundant calls

        private StreamReader streamReader;

        public string Name { get; }

        public string Email { get; }

        public Person(string fileName)
        {
            streamReader = new StreamReader(fileName);
            string contents = streamReader.ReadToEnd();
            string[] parts = contents.Split(' ');
            this.Name = parts[0];
            //this.Email = parts[1];
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (streamReader != null)
                    {
                        streamReader.Close();
                        streamReader.Dispose();
                    }
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~Person()
        {
            //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
    }

}
