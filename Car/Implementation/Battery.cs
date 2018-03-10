using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Interfaces;

namespace Car.Implementation
{
    /// <summary>
    /// Simple implementation of car battery  object
    /// </summary>
   public class Battery : IBattery
    {
        /// <summary>
        /// Checks the battery condition the moment we turn the key
        /// </summary>
        /// <returns></returns>
        bool IBattery.CheckInitialBattery()
        {

            Console.WriteLine("\t SubSystem Battery : CheckInitialBattery");
            return true;
        }

        /// <summary>
        /// Checks if battery is charged enough to start the engine
        /// </summary>
        /// <returns></returns>
        bool IBattery.IgniteEngine()
        {
            Console.WriteLine("\t SubSystem Battery : IgniteEngine");
            return true;
        }
    }
}
