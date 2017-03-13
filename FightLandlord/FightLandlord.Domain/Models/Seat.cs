using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Domain.Models
{
    public class Seat
    {
        public int Position { get; private set; }
        public Seat(int pos)
        {
            if (pos < 1 || pos > 4)
            {
                throw new ArgumentException("Create Seat Intance Faild!", pos.ToString());
            }
            Position = pos;
        }
        public User User { set; get; }
        public bool HasUser { get { return User != null; } }
        public List<Poker> PokerList { set; get; }
    }
}
