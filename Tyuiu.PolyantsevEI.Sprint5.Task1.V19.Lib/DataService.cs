﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PolyantsevEI.Sprint5.Task1.V19.Lib
{
    public class DataService : ISprint5Task1V19
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExits = fileInfo.Exists;

            if (fileExits)
            {
                File.Delete(path);
            }

            double y;
            string str;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) + 2/(3*x+0.5) - 2 * Math.Cos(x) * 2 * x, 2);

                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    y = 0;
                }

                str = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }

            return path;
        }
    }
}
