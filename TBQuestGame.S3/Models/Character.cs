using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Character : ObservableObject
    {
        #region ENUMERABLES
        public enum SpecialMoveName
        {
            Fireball,
            Tackle,
            Sweep,
            Superman,
            Powerpush,
            Uppercut,
            Megapunch,
        }
        #endregion

        #region FIELDS
        private int id;
        private string name;
        private int locationId;
        private int health;
        private SpecialMoveName specialMove;
        #endregion

        #region PROPERTIES
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int LocationId
        {
            get { return locationId; }
            set { locationId = value; }
        }
        
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                OnPropertyChanged(nameof(Health));
                 }
        }

        

        public SpecialMoveName SpecialMove
        {
            get { return specialMove; }
            set { specialMove = value; }
        }
        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, SpecialMoveName specialMove, int locationId, int health)
        {
            Name = name;
            SpecialMove = specialMove;
            LocationId = locationId;
            Health = health;
        }

        #endregion

        #region METHODS

        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {Name}. My special move is {SpecialMove}. I am ready to fight!";
        }

        #endregion




    }
}
