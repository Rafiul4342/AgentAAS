using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using HelloAssetAdministrationShell.I4MessageModel;

namespace HelloAssetAdministrationShell.CommunicationInterface
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetCommunicationInterface : Controller
    {
        [HttpPost]
        public async Task<IActionResult> SendCalulatedtime(I40Message message)
        {
            var Message = new I40Message
            {
                InteractionElement = message.InteractionElement,
                Type = message.Type,
                ConversationID = message.ConversationID
            };
            
            return Ok(Message);
            
        }
    }
}
