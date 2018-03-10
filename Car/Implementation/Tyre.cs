using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Interfaces;
namespace Car.Implementation
{
   public class Tyre : ITyre
    {
        /// <summary>
        /// Check the tyre pressure
        /// </summary>
        /// <returns></returns>
        bool ITyre.CheckTyrePressure()
        {
            Console.WriteLine("\t SubSystem Tyre : CheckTyrePressure");
            return true;
        }
    }
}
