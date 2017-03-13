using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Domain.Models
{
    public class SocketConnection
    {
        public string ConnId { set; get; }
        public ConnectionStatus Status { set; get; }
        public DateTime BeginDate { set; get; }
    }
    public enum ConnectionStatus
    {
        Connecting,
        Connected,
        Reconnecting,
        Disconnected
    }
}
