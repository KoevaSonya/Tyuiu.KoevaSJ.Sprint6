using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KoevaSJ.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];

            for (int x = startValue, count = 0; x <= stopValue; x++, count++)
            {
                valueArray[count] = Math.Round((Math.Cos(x) + ((4.0 * x) / 2.0) - Math.Sin(x) * 3.0 * x), 2);
            }
            return valueArray;
        }
    }
}
