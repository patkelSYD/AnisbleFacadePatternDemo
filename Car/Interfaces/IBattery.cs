using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Model;
namespace Car.Interfaces
{
    public interface IBattery
    {
        bool CheckInitialBattery();
        bool IgniteEngine();

    }
}
