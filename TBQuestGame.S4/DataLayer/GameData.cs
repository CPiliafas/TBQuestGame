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
                Name = "The Player",
                LocationId = 1,
                Health = 300,
                gender = Player.Gender.Male,
                Wins = 0,
                WaterBottles = 3,
                EnergyDrinks = 1,
                WinTickets = 0
            };
        }

        private static NPC NpcById(int id)
        {
            return NPCs().FirstOrDefault(i => i.Id == id);
        }

        public static List<NPC> NPCs()
        {
            return new List<NPC>()
            {
                new Fighter()
                {
                    Id = 1,
                    Name = "Zero",
                    LocationId = 2,
                    Health = 300,
                    SpecialMove = Character.SpecialMoveName.Superman,
                    Messages = new List<string>()
                    {
                        "Hi! My name is Zero. No, I am not gonna share my actual name. It's my secret identity. I'm gonna be the" +
                        " all star of Justice! Are you ready to fight?"
                    }
                },

                new Fighter()
            {
                Id = 2,
                Name = "Charlotte",
                LocationId = 3,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Uppercut,
                Messages = new List<string>()
                    {
                        "As a daughter of two celebrities and a French socialite, it only makes sense I learn some fighting skills! I wanna look pretty and kick" +
                        " some butt! I'll make sure to go easy on you."
                    }
            },

            new Fighter()
            {
                Id = 3,
                Name = "Shen",
                LocationId = 4,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Powerpush,
                Messages = new List<string>()
                    {
                        "You look like an easy fight. My father didn't train me day and night for me to lose to some nobody like you."
                    }
            },

            new Fighter()
            {
                Id = 4,
                Name = "Marcus",
                LocationId = 5,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Tackle,
                Messages = new List<string>()
                    {
                        "My name is Marcus. I am an interpol agent from Germany. It appears I have to fight you. A shame, you're impeding my " +
                        "investigation here."   
                    }
            },

            new Fighter()
            {
                Id = 5,
                Name = "Keiji",
                LocationId = 6,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Fireball,
                Messages = new List<string>()
                    {
                        "Huh? Oh, it's my next battle. You don't need to know why I have a sword."
                    }
            },

            new Fighter()
            {
                Id = 6,
                Name = "Mia",
                LocationId = 7,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Sweep,
                Messages = new List<string>()
                    {
                        "It's a shame we must fight, this beach party is fun and you look like you'd be fun at parties!"
                    }
            },

            new Boss()
            {
                Id = 7,
                Name = "Jack Cross",
                LocationId = 8,
                Health = 500,
                SpecialMove = Character.SpecialMoveName.Megapunch
            }

        };
        }

        public static Character CharacterData()
        {
            Character character = new Character();
            new Character()
            {
                Id = 1,
                Name = "Zero",
                LocationId = 2,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Superman
            };

            new Character()
            {
                Id = 2,
                Name = "Charlotte",
                LocationId = 3,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Uppercut
            };

            new Character()
            {
                Id = 3,
                Name = "Shen",
                LocationId = 4,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Powerpush
            };

            new Character()
            {
                Id = 4,
                Name = "Marcus",
                LocationId = 5,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Tackle
            };

            new Character()
            {
                Id = 5,
                Name = "Keiji",
                LocationId = 6,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Fireball
            };

            new Character()
            {
                Id = 6,
                Name = "Mia",
                LocationId = 7,
                Health = 300,
                SpecialMove = Character.SpecialMoveName.Sweep
            };

            new Character()
            {
                Id = 7,
                Name = "Jack Cross",
                LocationId = 8,
                Health = 500,
                SpecialMove = Character.SpecialMoveName.Megapunch
            };

            return character;
        }

        public static Location InitialGameLMapLocation()
        {
            return new Location()
            {
                Id = 1,
                Name = "United States (Home)",
                Description = "Your home country, you don't have any opponents to fight here. This can be a place you can visit at any time.",
                Accessible = true,
                ImageFileName = "united states.jpg",
                SongSource = "IntroScreen.wav"
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
                    Accessible = true,
                    ImageFileName = "united states.jpg",
                    SongSource = "IntroScreen.wav"
                },

                new Location()
                {
                    Id = 2,
                    Name = "England",
                    Description = "You find yourself near the Big Ben, and spot your opponent. His name is Zero. He's a scrawny young man dressed up similarly to a superhero. He" +
                    " is dressed up in the United Kingdom's flag colors. You decide not to underestimate him just because of how dorky he looks.",
                    Accessible = true,
                    ImageFileName = "united kingdom.jpg",
                    SongSource = "OffLimits.wav",
                    NPCs = new ObservableCollection<NPC>()
                    {
                        NpcById(1)
                    }
                },

                new Location()
                {
                    Id = 3,
                    Name = "France",
                    Description = "You arrived in Paris. Your opponent is Charlotte. She doesn't look like a fighter and more like some kind of model. Apparently" +
                    " she's the daughter of two French celebrities. She has golden blonde hair and an outfit you'd think is too fancy for a street fight.",
                    Accessible = true,
                    ImageFileName = "france.jpg",
                    SongSource = "PimPoy.wav",
                    NPCs = new ObservableCollection<NPC>()
                    {
                        NpcById(2)
                    }
                },

                new Location()
                {
                    Id = 4,
                    Name = "China",
                    Description = "The fight takes place in a dojo in Shanghai. You spot Shen, a tomboyish young woman in a traditional blue kung fu suit." +
                    "She seems rather grumpy and ready to fight.",
                    Accessible = true,
                    ImageFileName = "china.jpg",
                    SongSource = "ShanghaiAction1.wav",
                    NPCs = new ObservableCollection<NPC>()
                    {
                        NpcById(3)
                    }
                },

                new Location()
                {
                    Id = 5,
                    Name = "Germany",
                    Description = "Oktober Fest is currently going on as you get on the stage. Here you will face against Marcus, a stern and no nonsense looking man in a military looking suit." +
                    " He looks unamused to be here.",
                    Accessible = true,
                    ImageFileName = "germany.jpg",
                    SongSource = "StarCommander1.wav",
                    NPCs = new ObservableCollection<NPC>()
                    {
                        NpcById(4)
                    }
                },

                new Location()
                {
                    Id = 6,
                    Name = "Japan",
                    Description = "You will fight in Tokyo's city square. Here you will face against Keiji, a bit older than the rest of the fighters." +
                    "He doesn't look like your average Japanese man, is he a part of the Mafia?",
                    Accessible = true,
                    ImageFileName = "japan.jpg",
                    SongSource = "OnikuLoop2.wav",
                    NPCs = new ObservableCollection<NPC>()
                    {
                        NpcById(5)
                    }
                },

                new Location()
                {
                    Id = 7,
                    Name = "Jamaica",
                    Description = "The fight takes place on a sunny beach full of happy people dancing and partying. Here you will face against Mia," +
                    " a fun and flirty dancer who seems excited to fight. She's dressed for the summer weather.",
                    Accessible = true,
                    ImageFileName = "jamaica.jpg",
                    SongSource = "Platformer2.wav",
                    NPCs = new ObservableCollection<NPC>()
                    {
                        NpcById(6)
                    }
                },

                new Location()
                {
                    Id = 8,
                    Name = "Unknown Lab",
                    Description = "Here you will face against Cross, the final boss. The lab looks a bit shady, and Cross himself is intimidating. 'Talk is cheap'. He says.",
                    Accessible = false,                    
                    ImageFileName = "lab.jpg",
                    SongSource = "PowerBotsLoop.wav",
                    NPCs = new ObservableCollection<NPC>()
                    {
                        NpcById(7)
                    }
                },
            };

            gameMap.Locations = locations;

            return gameMap;

        }
    }
}

