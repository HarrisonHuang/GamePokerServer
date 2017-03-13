using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Domain.Models
{
    public class User
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string TableNo { set; get; }
        public int SeatPosition { set; get; }
        public SocketConnection Conn { set; get; }
    }
}
