using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
using System.Collections.ObjectModel;

namespace TBQuestGame.Models
{
    class WinTickets : GameItem
    {
        public int WinChange { get; set; }

        public WinTickets(int id, string name, int value, int winChange, string description)
            : base(id, name, value, description)
        {
            WinChange = winChange;
        }

        //public WinTickets(int id, string name, int value, string description, string useMessage)
        //{

        //}
        
        public override string InformationString()
        {
            if (WinChange != 0)
            {
                return $"{Name}: {Description}\nWin: {WinChange}";
            }
            else
            {
                return $"{Name}: {Description}";
            }
        }
    }
}
