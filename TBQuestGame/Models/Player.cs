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

        public Gender gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        #endregion

        #region PROPERTIES

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
            return $"Hello, my name is {_name} and I am a {_gender} from the United States. My special move is {_specialMove} and I'm ready to fight!";
        }

        #endregion

    }
}
