using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PolyantsevEI.Sprint5.Task0.V9.Lib;

namespace Tyuiu.PolyantsevEI.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.PolyantsevEI.Sprint5\Tyuiu.PolyantsevEI.Sprint5.Task0.V9\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
