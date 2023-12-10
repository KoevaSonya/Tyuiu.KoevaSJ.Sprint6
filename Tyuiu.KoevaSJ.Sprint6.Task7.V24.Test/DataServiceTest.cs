using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint6.Task7.V24.Lib;

namespace Tyuiu.KoevaSJ.Sprint6.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V24.csv";
            int[,] res = ds.GetMatrix(path);

            int[,] wait = {
                { -19, -4, 13, -11, -15,  5, -12, 20, 3, -19 },
                { -17,  1,  5,   1,   1,  1,   1,  1, 1,  -5 },
                {  11,-11,-10,  16,  18, 13, -17,-13, 1,   4 },
                {   2, -1,-17,  16,   4, -1,  20, 18,-5,  -2 },
                { -17,-13,  2, -12,   4,-16,  10,-16, 2,  -7 },
                {  -6,  4, -3,   2,  -4,  2, -10,  3, 5, -19 },
                {  11,  7, 20, -19,   1, 18,  -3,-18, 2,  11 },
                {  15,-14,-11,  17,  18,-18,   2, 18,19,   1 },
                {  -1,-12, -5,  10,  18, 13,   9,  3,-8,  16 },
                {   9,-20,-12,   9,  15, -1,   3,-11, 6,  -4 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
