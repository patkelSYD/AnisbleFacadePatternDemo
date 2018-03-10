using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFacade;

namespace AnisbleFacadePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Facade pattern hides the complex process of the subsystems and wrappes into one single interface.
             * Without using facade the user has to call all the subsystems individually. 
             * + decouples the client from the business logic of starting the car. 
             * 
             * **/

            iDriver driver = new Driver(); // Driver is the Facade.
            Console.WriteLine("-----------Facade Demo Start---------------");
            driver.StartTurnKey();
            Console.ReadLine();
        }
    }
}
