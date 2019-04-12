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
        private Map _gameMap;
        private Location _currentLocation;
        private string _currentLocationName;
        private ObservableCollection<Location> _accessibleLocations;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        //
        // return the list of strings converted to a single wtring with new lines between each message
        //
        public string MessageDisplay
        {
            get { return string.Join("\n\n", _message); }
        }

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
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

            Console.WriteLine("You have used a water bottle and restored 100 health.");

            if (_player.WaterBottles == 0)
            {
                Console.WriteLine("You are out of water Bottles.");
            }

            if (_player.Health >= 201)
            {
                Console.WriteLine("You cannot go above your 300 health max.");
            }
        }

        public void UseEnergyDrink()
        {
            _player.EnergyDrinks--;

            Console.WriteLine("You have used an energy drink. You're powered up!");

            if (_player.EnergyDrinks == 0)
            {
                Console.WriteLine("You have used your energy drink already.");
            }
        }

        public void playBtn_Click()
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = _currentLocation.SongPath;
            player.Play();
        }

        public void pauseBtn_Click()
        {
            player.Stop();
        }
        #endregion

        #region EVENTS
        #endregion
    }
    }

