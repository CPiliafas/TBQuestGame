using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.DataLayer
{
    class GameData
    {
        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "Every year, a major fighting and martial arts tournament takes place. This is the Fatal Fist tournament. One representative" +
                "from each country has been chosen to fight for a cash prize of 5 million dollars and the title of King/Queen of Fatal Fist." +
                "You are the representative of North America, and aim to win the cash prize to help out your struggling parents. Travel to the 6 different" +
                "locations and win the Fatal Fist tournament. You will begin by selecting a country to face your first opponent."

            };
        }

        public static Player PlayerData()
        {
            return new Player()
            {
                _id = 1,
                _name = "Bonzo",
                _locationId = 1,
                _health = 300,
                gender = Player.Gender.Male,
                _specialMove = Character.SpecialMove.Megapunch
            };
        }

    }
}

