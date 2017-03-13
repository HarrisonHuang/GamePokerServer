using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightLandlord.Domain.Models
{
    public class Poker : IComparable
    {
        public PokerName Name { set; get; }
        public PokerFlower Flower { set; get; }
        public Poker(int name, int flower)
        {
            Name = (PokerName)name;
            Flower = (PokerFlower)flower;
        }
        public Poker(PokerName name, PokerFlower flower)
        {
            Name = name;
            Flower = flower;
        }
        public Poker(string pokerStr)
        {
            string[] array = pokerStr.Split('|');
            if (array.Length != 2)
            {
                throw new ArgumentException("Create Poker Intance Faild!", pokerStr);
            }
            Name = (PokerName)Convert.ToInt32(array[1]);
            Flower = (PokerFlower)Convert.ToInt32(array[0]);
        }

        public override string ToString()
        {
            return (int)Flower + "|" + (int)Name;
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Poker targetPoker = null;
            if(obj is Poker)
            {
                targetPoker = obj as Poker;
            }
            else
            {
                targetPoker = new Poker(obj.ToString());
            }
            return (int)this.Name - (int)targetPoker.Name;
        }
    }
    public enum PokerName
    {
        P3 = 1,
        P4,
        P5,
        P6,
        P7,
        P8,
        P9,
        P10,
        J,
        Q,
        K,
        A,
        P2,
        JokerMin,
        JokerMax
    }
    public enum PokerFlower
    {
        Null = 0,
        Spade = 1,
        Heart = 2,
        Club = 3,
        Diamond = 4,
        Joker = 6,
    }
    public class PokerCollection
    {
        public static List<Poker> AllPokers = new List<Poker>{
            new Poker(1,1),new Poker(1,2),new Poker(1,3),new Poker(1,4),
            new Poker(2,1),new Poker(2,2),new Poker(2,3),new Poker(2,4),
            new Poker(3,1),new Poker(3,2),new Poker(3,3),new Poker(3,4),
            new Poker(4,1),new Poker(4,2),new Poker(4,3),new Poker(4,4),
            new Poker(5,1),new Poker(5,2),new Poker(5,3),new Poker(5,4),
            new Poker(6,1),new Poker(6,2),new Poker(6,3),new Poker(6,4),
            new Poker(7,1),new Poker(7,2),new Poker(7,3),new Poker(7,4),
            new Poker(8,1),new Poker(8,2),new Poker(8,3),new Poker(8,4),
            new Poker(9,1),new Poker(9,2),new Poker(9,3),new Poker(9,4),
            new Poker(10,1),new Poker(10,2),new Poker(10,3),new Poker(10,4),
            new Poker(11,1),new Poker(11,2),new Poker(11,3),new Poker(11,4),
            new Poker(12,1),new Poker(12,2),new Poker(12,3),new Poker(12,4),
            new Poker(13,1),new Poker(13,2),new Poker(13,3),new Poker(13,4),
            new Poker(14,6),new Poker(15,6),
            new Poker(1,1),new Poker(1,2),new Poker(1,3),new Poker(1,4),
            new Poker(2,1),new Poker(2,2),new Poker(2,3),new Poker(2,4),
            new Poker(3,1),new Poker(3,2),new Poker(3,3),new Poker(3,4),
            new Poker(4,1),new Poker(4,2),new Poker(4,3),new Poker(4,4),
            new Poker(5,1),new Poker(5,2),new Poker(5,3),new Poker(5,4),
            new Poker(6,1),new Poker(6,2),new Poker(6,3),new Poker(6,4),
            new Poker(7,1),new Poker(7,2),new Poker(7,3),new Poker(7,4),
            new Poker(8,1),new Poker(8,2),new Poker(8,3),new Poker(8,4),
            new Poker(9,1),new Poker(9,2),new Poker(9,3),new Poker(9,4),
            new Poker(10,1),new Poker(10,2),new Poker(10,3),new Poker(10,4),
            new Poker(11,1),new Poker(11,2),new Poker(11,3),new Poker(11,4),
            new Poker(12,1),new Poker(12,2),new Poker(12,3),new Poker(12,4),
            new Poker(13,1),new Poker(13,2),new Poker(13,3),new Poker(13,4),
            new Poker(14,6),new Poker(15,6)
        };

        public static Queue<Poker>[] Shuffle()
        {
            var list = new List<Poker>();
            list.AddRange(AllPokers);
            Queue<Poker>[] porkerArray = new Queue<Poker>[6] { new Queue<Poker>(), new Queue<Poker>(), new Queue<Poker>(), new Queue<Poker>(), new Queue<Poker>(), new Queue<Poker>() };
            var random = new Random();
            while (list.Count > 8)
            {
                for (int i = 0; i < 5; i++)
                {
                    var index = random.Next(list.Count);
                    porkerArray[i].Enqueue(list[index]);
                    list.RemoveAt(index);
                }
            }
            foreach (var info in list)
            {
                porkerArray[5].Enqueue(info);
            }
            return porkerArray;
        }
    }
}
