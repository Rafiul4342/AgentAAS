using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using HelloAssetAdministrationShell.I4MessageModel;
using HelloAssetAdministrationShell.AgentFunction;



namespace HelloAssetAdministrationShell.CommunicationInterface
{
    [Route("agent/I40Com")]
    [ApiController]
    public class AssetCommunicationInterface : Controller
    {
        private readonly Agent agent = new Agent();
        [HttpPost]
        public async Task<IActionResult> SendCalulatedtime(I40Message message)
        {
            var Message = new I40Message
            {
                InteractionElement = message.InteractionElement,
                Type = message.Type,
                ConversationID = message.ConversationID, 
            };
            var data = Message.InteractionElement;
            Time t = new Time { Hours = 12, Minutes = 10, Seconds = 20 };
            var result = await agent.CalculateRemainingUsefulLife();
         
          
            return Ok(result);
            
        }
    }
}
