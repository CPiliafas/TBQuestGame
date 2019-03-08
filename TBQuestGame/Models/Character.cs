using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Character 
    {
        #region ENUMERABLES
        public enum SpecialMove
        {
            Fireball,
            Tackle,
            Sweep,
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
        private SpecialMove specialMove;
        #endregion

        #region PROPERTIES
        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        public int _locationId
        {
            get { return locationId; }
            set { locationId = value; }
        }
        
        public int _health
        {
            get { return health; }
            set { health = value; }
        }

        

        public SpecialMove _specialMove
        {
            get { return specialMove; }
            set { specialMove = value; }
        }
        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, SpecialMove specialMove, int locationId, int health)
        {
            _name = name;
            _specialMove = specialMove;
            _locationId = locationId;
            _health = health;
        }

        #endregion

        #region METHODS

        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {_name}. My special move is {_specialMove}. I am ready to fight!";
        }

        #endregion




    }
}
