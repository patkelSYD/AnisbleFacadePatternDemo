using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Interfaces;
using Car.Implementation;

namespace CarFacade
{
    public class Driver : iDriver
    {
        /// <summary>
        /// This is the implementation of Facade pattern where it hide all the complexity of various subsystems. 
        /// In this instance we are exposing 1 interface compared to 4. Enabling user 
        /// </summary>
        /// <returns></returns>
        bool iDriver.StartTurnKey()
        {
            Console.WriteLine("Start Car");

            ICarKey driverCarkey = new CarKey();
            IBattery carBattery = new Battery();
            IEngine carEngine = new Engine();
            ITyre carTyre = new Tyre();

            //All the subsystems are managed under one Facade (Interface)
            if( (driverCarkey.Validatecarkey())
                && (carBattery.CheckInitialBattery())
                    && (carEngine.CheckEngineServiceDue())
                        &&(carEngine.CheckEngineTemperature())
                            &&(carTyre.CheckTyrePressure())
                            && (carBattery.IgniteEngine()))
            {
                return carEngine.EngineStarted();
            }



            return true;
        }
    }
}
