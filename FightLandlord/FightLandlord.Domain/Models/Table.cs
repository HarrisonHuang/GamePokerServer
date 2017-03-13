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
        public Table(string name)
        {
            Name = name;
        }
    }
}
