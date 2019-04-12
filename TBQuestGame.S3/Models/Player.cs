using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Player : Character
    {
        #region ENUMERABLES

        public enum Gender { Male, Female }

        #endregion

        #region FIELDS

        private Gender _gender;

        private int _wins;
        private int _waterBottles;
        private int _energyDrinks;
        private int _winTickets;
        


        #endregion

        #region PROPERTIES
        public Gender gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int Wins
        {
            get { return _wins; }
            set
            {
                _wins = value;
                OnPropertyChanged(nameof(_wins));
            }
        }

        public int WaterBottles
        {
            get { return _waterBottles; }
            set { _waterBottles = value;
                OnPropertyChanged(nameof(WaterBottles));
            }
        }



        public int EnergyDrinks
        {
            get { return _energyDrinks; }
            set { _energyDrinks = value;
                OnPropertyChanged(nameof(_energyDrinks));
            }
        }

        public int WinTickets
        {
            get { return _winTickets; }
            set { _winTickets = value;
                OnPropertyChanged(nameof(_winTickets));
            }
        }


        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS

        ///<summary>
        /// override the default greeting in the character class to include gender
        /// </summary>
        /// <returns>default greeting</returns>

        public override string DefaultGreeting()
        {
            return $"Hello, my name is {Name} and I am a {_gender} from the United States. My special move is {SpecialMove} and I'm ready to fight!";
        }

        #endregion

    }
}
