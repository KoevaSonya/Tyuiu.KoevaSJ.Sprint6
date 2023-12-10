using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KoevaSJ.Sprint6.Task6.V15.Lib;

using System.IO;

namespace Tyuiu.KoevaSJ.Sprint6.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V15.txt";
            string wait = "HlidZPHKeLLU OoyPFhjSRwp GUilXww iukCfO UaZNpcgYjw  ";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
