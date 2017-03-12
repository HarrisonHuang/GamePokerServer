using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Domain
{
    public class MessageReceiver : Receiver
    {
        public MessageReceiver(Hub<IClient> hub) : base(hub)
        {
        }
        public override void Action()
        {
            hub.Clients.Caller.ShowMsg(hub.Context.ConnectionId);
        }
    }
}
