using Microsoft.AspNet.SignalR;

namespace FightLandlord.Domain.Commands
{
    public class MessageCommand : Command
    {
        public override void Execute()
        {
            receiver.Action();
        }

        public override void Initial(Hub<IClient> hub, string data)
        {
            receiver = new MessageReceiver(hub);
        }
    }
}
