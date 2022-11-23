using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaSyx.Models.Extensions;
using BaSyx.Models;
using BaSyx.Models.Core.AssetAdministrationShell.Implementations;

namespace HelloAssetAdministrationShell.I4MessageModel
{
    public class I40Message
    {
        public Submodel InteractionElement { get; set; }
        public string Type { get; set; }
        public string Sender { get; set;}
        public string Receiver { get; set; }
        public string ConversationID { get; set; }
        public string MessageID { get; set; }
        public string InReplyTO { get; set; }
        public string InReplyBy { get; set; }
        public string Replyby { get; set; }
        public string SemanticProtocol { get; set; }
        public string Role { get; set; }

    }
}
