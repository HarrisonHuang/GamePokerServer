using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Domain.Models
{
    public class Table
    {
        public string Name { get; private set; }
        private Seat[] Seats = {
            new Seat(1), new Seat(2), new Seat(3), new Seat(4)
        };
        public CurrentRound current = new CurrentRound();
        public List<Poker> AdditonalPokers { set; get; }
        public Table(string name)
        {
            Name = name;
        }
    }
}
