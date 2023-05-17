using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programm
{
    public class Towns
    {
        public Towns(string filePath)
        {
            UnUsedNames = new List<string>();
            AlreadyUsedNames = new List<string>();  
            StreamReader reader = new StreamReader("town_names.txt");
            string? name = reader.ReadLine();
            while (name != null)
            {
                UnUsedNames.Add(name);
                name = reader.ReadLine();
            }
        }
        public List<string> AlreadyUsedNames { get; }
        public List<string> UnUsedNames { get; }
    }
}
