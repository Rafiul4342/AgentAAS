using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloAssetAdministrationShell.I4MessageModel;

namespace HelloAssetAdministrationShell.AgentFunction
{
    public class Agent
    {

        public Dictionary<string, Component[]> MachineSpecificComponentMaintenanceInterval { get; set; }

        Component com1 = new Component
        {
            Name = "Spindle",
            MaintenanceIntervals = new double[] { 200, 500, 1000, 2000 },
            UnitofTime = "Hours"
        };

        Component com2 = new Component
        {
            Name = "drive",
            MaintenanceIntervals = new double[] { 200, 500, 1000, 2000 },
            UnitofTime = "Hours"
        };
        /*      void SetMachineSpecificComponentMaintenanceInterval(string name, Component com) 
              {
                  this.MachineSpecificComponentMaintenanceInterval.Add(name, com);
                  Console.WriteLine("mentenance Interval set");
              }
           */
        public async Task<Time> CalculateRemainingUsefulLife()
        {
            await Task.Delay(1000);
            return new Time { Hours = 1, Minutes = 20, Seconds = 5 };

        }
    }
}
