using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Interfaces;
namespace Car.Implementation
{
    /// <summary>
    /// Car Engine
    /// </summary>
    public class Engine : IEngine
    {
        /// <summary>
        /// Has engine started
        /// </summary>
        /// <returns></returns>
        public bool EngineStarted()
        {
            Console.WriteLine("\t SubSystem Engine : EngineStarted");
            return true;
        }
        /// <summary>
        /// Checks the next due date
        /// </summary>
        /// <returns></returns>

        bool IEngine.CheckEngineServiceDue()
        {

            Console.WriteLine("\t SubSystem Engine : CheckEngineServiceDue");
            return true;
            
        }
        /// <summary>
        /// 
        /// Check for engine temperature before starting
        /// </summary>
        /// <returns></returns>

        bool IEngine.CheckEngineTemperature()
        {
            Console.WriteLine("\t SubSystem Engine : CheckEngineTemperature");
            return true;
            
        }
    }
}
