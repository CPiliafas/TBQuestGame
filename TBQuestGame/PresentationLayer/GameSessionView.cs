using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.PresentationLayer
{
    public class GameSessionViewModel
    {
        #region FIELDS

        private Player _player;
        private List<string> _message;
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
        #endregion

        #region CONSTRUCTORS
        
        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(
            Player player,
                List<string> initialMessages)
        {
            _player = player;
            _message = initialMessages;
        }
        #endregion
    }
}
