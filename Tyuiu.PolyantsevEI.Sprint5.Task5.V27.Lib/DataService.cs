using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PolyantsevEI.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            double count = 0;
            using(StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 5 == 0)
                    {
                        sum += Convert.ToDouble(line);
                        count++;
                    }
                }
            }
            return Math.Round(sum / count, 3);
        }
    }
}
