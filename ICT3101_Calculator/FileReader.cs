using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator
{
    public class FileReader : IFileReader
    {
        public FileReader() { }

        public string[] Read(string path)
        {
            if (!IsPath(path)) { throw new FileNotFoundException($"{path} does not exists"); }
            try
            {
                return File.ReadAllLines(path);
            }
            catch (IOException e)
            {
                throw new IOException($"Failed to read the file at {path}.", e);
            }
        }

        public bool IsPath(string path)
        {
            return File.Exists(path);
        }
    }

}
