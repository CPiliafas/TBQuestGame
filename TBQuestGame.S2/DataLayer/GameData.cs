using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
using System.Collections.ObjectModel;

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
                Id = 1,
                Name = "Jack",
                LocationId = 1,
                Health = 300,
                gender = Player.Gender.Male,
                SpecialMove = Character.SpecialMoveName.Megapunch
            };
        }

        public static Location InitialGameLMapLocation()
        {
            return new Location()
            {
                Id = 1,
                Name = "United States (Home)",
                Description = "Your home country, you don't have any opponents to fight here. This can be a place you can visit at any time.",
                Accessible = true
            };
        }

        public static Map GameMapData()
        {
            Map gameMap = new Map();
            ObservableCollection<Location> locations = new ObservableCollection<Location>()
            {
                new Location()
                {
                    Id = 1,
                    Name = "United States (Home)",
                    Description = "Your home country, you don't have any opponents to fight here. This can be a place you can visit at any time.",
                    Accessible = true
                },

                new Location()
                {
                    Id = 2,
                    Name = "England",
                    Description = "A country in the United Kingdom, here you will face against Zero.",
                    Accessible = true
                },

                new Location()
                {
                    Id = 3,
                    Name = "France",
                    Description = "Here you will face against Charlotte",
                    Accessible = true
                },

                new Location()
                {
                    Id = 4,
                    Name = "China",
                    Description = "Here you will face against Shen",
                    Accessible = true
                },

                new Location()
                {
                    Id = 5,
                    Name = "Germany",
                    Description = "Here you will face against Marcus",
                    Accessible = true
                },

                new Location()
                {
                    Id = 6,
                    Name = "Japan",
                    Description = "Here you will face against Keiji",
                    Accessible = true
                },

                new Location()
                {
                    Id = 7,
                    Name = "Jamaica",
                    Description = "Here you will face against Mia",
                    Accessible = true
                },

                new Location()
                {
                    Id = 8,
                    Name = "Unknown Lab",
                    Description = "Here you will face against Cross, the final boss.",
                    Accessible = false
                },
            };

            gameMap.Locations = locations;

            return gameMap;
        }
    }
}

