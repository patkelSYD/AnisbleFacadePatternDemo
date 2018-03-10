using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Interfaces;

namespace Car.Implementation
{
    /// <summary>
    /// Car Key
    /// </summary>
   public class CarKey : ICarKey
    {
        /// <summary>
        /// Check if driver has the correct key
        /// </summary>
        /// <returns></returns>
        bool ICarKey.Validatecarkey()
        {
            Console.WriteLine("\t SubSystem CarKay : Validatecarkey");
            return true;
            
        }
    }
}
