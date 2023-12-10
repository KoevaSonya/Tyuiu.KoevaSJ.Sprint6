using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KoevaSJ.Sprint6.Task6.V15.Lib
{
    public class DataService : ISprint6Task6V15
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] new_line = line.Split(' ');
                    resStr += new_line.Last() + " ";
                }
            }
            return resStr;
        }
    }
}
