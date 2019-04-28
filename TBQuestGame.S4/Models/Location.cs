using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Media;
using System.Collections.ObjectModel;

namespace TBQuestGame.Models
{
    public class Location
    {
        #region FIELDS

        private int _id;
        private string _name;
        private string _description;
        private bool _accessible;
        private int _wins;
        private string _imageFileName;
        private string _songSource;
        private string _message;
        private ObservableCollection<NPC> _npcs;
        #endregion

        #region PROPERTIES

        public bool Accessible
        {
            get { return _accessible; }
            set { _accessible = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        public string SongSource
        {
            get { return _songSource; }
            set { _songSource = value; }
        }

        public string SongPath
        {
            get { return @"Music/" + _songSource; }
        }

        public ObservableCollection<NPC> NPCs { get; set; }

        #endregion

        #region CONSTRUCTORS

        public Location()
        {

        }

        #endregion

        #region METHODS

        public override string ToString()
        {
            return _name;
        }

        #endregion
    }
}
