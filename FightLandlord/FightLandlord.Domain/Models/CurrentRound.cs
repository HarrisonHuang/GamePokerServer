using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Domain.Models
{
    public class CurrentRound
    {
        public List<Poker>[] PokersList = new List<Poker>[5] {
            new List<Poker>(), new List<Poker>(), new List<Poker>(), new List<Poker>(), new List<Poker>()
        };
        public int MaxPos { set; get; }
        public int Turn { set; get; }
        public int Position { set; get; }
        public int Round { set; get; }
        public int Time { set; get; }
        public void NextTurn()
        {
            Time = 0;
            Turn++;
            Position++;
            if (Position > 4)
            {
                Position = 1;
            }
            if(MaxPos == Position)
            {
                NextRound();
            }
        }
        public void NextRound()
        {
            Position = MaxPos;
            Round++;
            Turn = 1;
            ClearPokerList();
        }
        public void ClearPokerList()
        {
            foreach (var pokers in PokersList)
            {
                pokers.Clear();
            }
        }
        public void Play(List<Poker> pokers)
        {
            PokersList[Position] = pokers;
            MaxPos = Position;
            NextTurn();
        }
    }
}
