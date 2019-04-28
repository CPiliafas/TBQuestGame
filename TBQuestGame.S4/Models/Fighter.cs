using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TBQuestGame.Models.BattleModeName;
using TBQuestGame.DataLayer;
using TBQuestGame.Models;
using System.Collections.ObjectModel;

namespace TBQuestGame.Models
{
    public class Fighter : NPC, ISpeak, IFight
    {
        Random r = new Random();
        private const int DAMAGE = 20;
        private const int MISS = 0;

        private List<string> messages;
        public List<string> Messages { get; set; }
        public int Health { get; set; }
        public BattleModeName BattleMode { get; set; }
        public int Punch { get; set; }
        public int Kick { get; set; }
        public int Miss { get; set; }

        protected override string InformationText()
        {
            return $"{Name} - {Description}";
        }

        public Fighter()
        {

        }

        public Fighter(
            int id,
            string name,
            int locationId,
            SpecialMoveName specialMove,
            string description,
            List<string> Messages)
             : base(id, name, specialMove, description)
        {
            Messages = messages;
        }

        public string Speak()
        {
            if (this.Messages != null)
            {
                return GetMessage();
            }
            else
            {
                return "";
            }
        }

        private string GetMessage()
        {
            int messageIndex = r.Next(0, Messages.Count());
            return Messages[messageIndex];
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
