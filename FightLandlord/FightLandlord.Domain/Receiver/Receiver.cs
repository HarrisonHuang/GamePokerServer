using Microsoft.AspNet.SignalR;

namespace FightLandlord.Domain
{
    public abstract class Receiver
    {
        protected Hub<IClient> hub;
        public Receiver(Hub<IClient> hub)
        {
            this.hub = hub;
        }
        public abstract void Action();
    }
}
