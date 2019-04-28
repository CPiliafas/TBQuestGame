using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    class EnergyDrink : GameItem
    {
        public int PowerChange { get; set; }

        public EnergyDrink(int id, string name, int value, int powerChange, string description)
            : base(id, name, value, description)
        {
            PowerChange = powerChange;
        }

        public override string InformationString()
        {
            if (PowerChange != 0)
            {
                return $"{Name}: {Description}\nPower: {PowerChange}";
            }
            else
            {
                return $"{Name}: {Description}";
            }
        }
    }
}
