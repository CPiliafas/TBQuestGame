using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public abstract class NPC : Character
    {
        private int id;
        private string name;

        public string Description { get; set; }

        public string Information
        {
            get
            {
                return InformationText();
            }
            set
            {

            }
        }


        public NPC()
        {

        }

        public NPC(int id, string name, int locationId, int health, SpecialMoveName specialMove)
            : base(id, name, locationId, health, specialMove)
        {
            Id = id;
            Name = name;
            LocationId = locationId;
            Health = health;
            SpecialMove = specialMove;

        }

        public NPC(int id, string name, SpecialMoveName specialMove, string description)
        {
            this.Id = id;
            this.Name = name;
            this.SpecialMove = specialMove;
            Description = description;
        }

        protected abstract string InformationText();

 
    }
}
