using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //added this Input Object

namespace Assignment9_nbrown
{
    class RightFile //WriteFile
    {
        private StreamWriter writer;
        string filepath = null;

        public RightFile(string path)
        {
            try
            {
                filepath = path;
                writer = new StreamWriter(path, true);
            }
            
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AddText(string line)
        {
            writer.Write(line); //writes whatever we pass into the file
        }

        public void CloseFile()
        {
            writer.Close();
        }
    }
}
