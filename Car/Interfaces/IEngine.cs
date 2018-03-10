using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Interfaces
{
    public interface IEngine
    {
        bool CheckEngineServiceDue();
        bool CheckEngineTemperature();

        bool EngineStarted();
    }
}
