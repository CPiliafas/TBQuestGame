using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
using TBQuestGame.DataLayer;

namespace TBQuestGame.Models
{
    internal class Boss : NPC, IFight
    {
        public BattleModeName BattleMode { get; set; }
        public int Punch { get; set; }
        public int Kick { get; set; }

        protected override string InformationText()
        {
            return $"{Name} - {Description}";
        }

        int IFight.Punch()
        {
            if (Health <= 300)
            {
                return Health;
            }
            else
            {
                return 100;
            }
        }

        int IFight.Kick()
        {
            if (Health <= 300)
            {
                return Health;
            }
            else
            {
                return 100;
            }
        }

        int IFight.SpecialMove()
        {
            if (Health <= 300)
            {
                return Health;
            }
            else
            {
                return 100;
            }
        }
    }
}
