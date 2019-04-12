using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    class WaterBottle : GameItem
    {
        public int HealthChange { get; set; }

        public WaterBottle(int id, string name, int value, int healthchange, string description)
            : base(id, name, value, description)
        {
            HealthChange = HealthChange;
        }

        public override string InformationString()
        {
            if (HealthChange != 0)
            {
                return $"{Name}: {Description}\nHealth: {HealthChange}";
            }
            else
            {
                return $"{Name}: {Description}";
            }
        }

        public enum UseActionType
        {
            HEALPLAYER,
            DONTHEALPLAYER
        }

    }
}
