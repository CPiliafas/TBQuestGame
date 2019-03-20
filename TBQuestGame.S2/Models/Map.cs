using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TBQuestGame.Models
{
    public class Map
    {

        #region FIELDS

        private ObservableCollection<Location> _locations;
        private Location _currentLocation;

        #endregion

        #region PROPERTIES

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }


        public ObservableCollection<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        public ObservableCollection<Location> AccessibleLocations()
        {
            ObservableCollection<Location> accessibleLocation = new ObservableCollection<Location>();

            foreach (var location in _locations)
            {
                if (location.Accessible == true)
                {
                    accessibleLocation.Add(location);
                }
            }

            return accessibleLocation;
        }


        #endregion

        #region CONSTRUCTORS

        

        #endregion

        #region METHODS

        public void Move(Location location)
        {
            _currentLocation = location;
        }

        public bool CanMove(Location location)
        {
            return location.Accessible;
        }

        #endregion

    }
}
