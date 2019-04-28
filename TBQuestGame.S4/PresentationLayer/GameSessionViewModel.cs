using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Media;
using System.Windows;
using TBQuestGame.PresentationLayer;
using System.Windows.Shapes;

namespace TBQuestGame.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {
        #region FIELDS

        private Player _player;
        private List<string> _message;
        private string _messages;
        private Map _gameMap;
        private Location _currentLocation;
        private string _currentLocationName;
        private ObservableCollection<Location> _accessibleLocations;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private Random random = new Random();
        private NPC _currentNpc;

        

        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        //
        // return the list of strings converted to a single wtring with new lines between each message
        
        public string Messages
        {
            get { return _messages; }
            set
            {
                _messages = value;
                OnPropertyChanged(nameof(Messages));
            }
        }


        public string MessageDisplay
        {
            get { return Messages; }
        }

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                CurrentLocationInformation = _currentLocation.Description;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(CurrentLocationInformation));
            }
        }


        public Map GameMap
        {
            get { return _gameMap; }
            set { _gameMap = value; }
        }

        public ObservableCollection<Location> AccessibleLocations
        {
            get
            {
                return _accessibleLocations;
            }
            set
            {
                _accessibleLocations = value;
                OnPropertyChanged(nameof(AccessibleLocations));
            }
        }


        public string CurrentLocationName
        {
            get { return _currentLocationName; }
            set
            {
                _currentLocationName = value;
                OnPlayMove();
                OnPropertyChanged("CurrentLocation");
            }
        }

        public NPC CurrentNpc
        {
            get { return _currentNpc; }
            set
            {
                _currentNpc = value;
                OnPropertyChanged(nameof(CurrentNpc));
            }
        }

        public string CurrentLocationInformation { get; private set; }

        #endregion

        #region CONSTRUCTORS

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(
            Player player,
                List<string> initialMessages,
            Map gameMap,
            Location currentLocation)
        {
            _player = player;
            _message = initialMessages;
            _gameMap = gameMap;
            _currentLocation = currentLocation;
            _accessibleLocations = _gameMap.AccessibleLocations();
            

        }
        #endregion

        #region METHODS

        private void OnPlayMove()
        {
            Location newLocation = new Location();
            

            foreach (Location location in AccessibleLocations)
            {
                if (location.Name == _currentLocationName)
                {
                    newLocation = location;
                }
            }

            //Location location = AccessibleLocations.FirstOrDefault(l => l.Name == _currentLocationName);
            _gameMap.CurrentLocation = newLocation;
            _currentLocation = newLocation;
            

            OnPropertyChanged(nameof(MessageDisplay));
            UpdateAccessibleLocations();
        }
        private void UpdateAccessibleLocations()
        {
            _accessibleLocations.Clear();

            //
            // add all accessible locations to list
            //
            foreach (Location location in _gameMap.Locations)
            {
                if (location.Accessible == true)
                {
                    _accessibleLocations.Add(location);
                }
            }
            OnPropertyChanged(nameof(AccessibleLocations));
        }

        public void UseWaterBottle()
        {
            _player.WaterBottles--;

            _player.Health += 100;

            Messages = "You have used a water bottle and restored 100 health.";

            if (_player.WaterBottles == 0)
            {
                Messages = "You are out of water Bottles.";
            }

            if (_player.Health >= 201)
            {
                Messages = "You cannot go above your 300 health max.";
            }
        }

        public void UseEnergyDrink()
        {
            Player.EnergyDrinks--;

            Messages = "You have used an energy drink. You're powered up!";

            if (_player.EnergyDrinks == 0)
            {
                Messages = "You have used your energy drink already.";
            }
        }

        public void playBtn_Click()
        {
            player.SoundLocation = _currentLocation.SongPath;
            player.Play();
        }

        public void pauseBtn_Click()
        {
            player.Stop();
        }

        #region ISPEAK METHODS
        public void OnPlayerTalkTo()
        {
            if (CurrentNpc != null && CurrentNpc is ISpeak)
            {
                ISpeak speakingNpc = CurrentNpc as ISpeak;
                Messages = speakingNpc.Speak();
            }
        }
        #endregion

        #region IFIGHT METHODS
        private BattleModeName NpcBattleResponse()
        {
            BattleModeName npcBattleResponse = BattleModeName.PUNCH;
            switch (DieRoll(3))
            {
                case 1:
                    npcBattleResponse = BattleModeName.PUNCH;
                    break;
                case 2:
                    npcBattleResponse = BattleModeName.KICK;
                    break;
                case 3:
                    npcBattleResponse = BattleModeName.SPECIALMOVE;
                    break;
            }

            return npcBattleResponse;
        }

        private int CalculatePlayerHealth()
        {
            int playerHealth = 0;

            switch (_player.BattleMode)
            {
                case BattleModeName.PUNCH:
                    playerHealth = _player.Punch();
                    break;
                case BattleModeName.KICK:
                    playerHealth = _player.Kick();
                    break;
                    //case BattleModeName.SPECIALMOVE:
                    //    playerHealth = _player.SpecialMove();
                    //    break;
            }

            return playerHealth;

        }

        private int CalculateNpcHitPoints(IFight battleNpc)
        {
            int battleNpcHitPoints = 0;

            switch (NpcBattleResponse())
            {
                case BattleModeName.PUNCH:
                    battleNpcHitPoints = battleNpc.Punch();
                    break;
                case BattleModeName.KICK:
                    battleNpcHitPoints = battleNpc.Kick();
                    break;
                case BattleModeName.SPECIALMOVE:
                    battleNpcHitPoints = battleNpc.SpecialMove();
                    break;
            }
            return battleNpcHitPoints;
        }

        private void Battle()
        {
            if (_currentNpc is IFight)
            {
                IFight battleNpc = _currentNpc as IFight;
                int playerHitPoints = 0;
                int battleNpcHitPoints = 0;
                string Message = "";

                Message +=
                    $"Player: {_player.BattleMode} Health:{playerHitPoints}" + Environment.NewLine +
                    $"NPC: {battleNpc.BattleMode} Health:{battleNpcHitPoints}" + Environment.NewLine;

                if (playerHitPoints >= battleNpcHitPoints)
                {
                    Messages += $"You have defeated {CurrentNpc.Name} and got their win ticket!";
                    _player.WinTickets += 1;
                    _player.Wins += 1;
                    _currentLocation.NPCs.Remove(_currentNpc);
                }
                else
                {
                    Messages += $"You have been defeated by {_currentNpc.Name}";
                }

                CurrentLocationInformation = Messages;
                if (_player.Health <= 0) OnPlayerDies("You have been defeated and lost the tournament.");

            }
        }

        private void QuitApplication()
        {
            Environment.Exit(0);
        }

        private void OnPlayerDies(string v)
        {
            QuitApplication();
        }

        public void OnPlayerPunch()
        {
            _player.BattleMode = BattleModeName.PUNCH;
            Battle();
        }

        public void OnPlayerKick()
        {
            _player.BattleMode = BattleModeName.KICK;
            Battle();
        }

        public void OnPlayerSpecialMove()
        {
            _player.BattleMode = BattleModeName.SPECIALMOVE;
            Battle();
        }
        #endregion


        #endregion

        #region HELPER METHODS

        private int DieRoll(int sides)
        {
            return random.Next(1, sides + 1);
        }
        #endregion
        
        #region EVENTS
        #endregion
    }
}

