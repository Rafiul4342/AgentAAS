using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAssetAdministrationShell.AgentFunction
{
    public class Agent
    {
        public Dictionary<string, Component> ComponentRuntine { get; set; }

        Component com = new Component
        {
            Name = "Spindle",
            MaxiumRuntime = 200,
            UnitofTime = "Hours"
        };

        Component com2 = new Component
        {
            Name = "drive",
            MaxiumRuntime = 200,
            UnitofTime = "Hours"
        };


    }
}
