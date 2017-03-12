using Microsoft.AspNet.SignalR;

namespace FightLandlord.Domain.Commands
{
    public abstract class Command
    {
        protected Receiver receiver;
        public abstract void Execute();
        public abstract void Initial(Hub<IClient> hub, string data);
    }
}
