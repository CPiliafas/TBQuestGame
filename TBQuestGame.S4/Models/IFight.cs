using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    interface IFight
    {
        int Health { get; set; }
        BattleModeName BattleMode { get; set; }        

        int Punch();
        int Kick();
        int SpecialMove();



        //int Punch()
        //{
        //    if (health <= 300)
        //    {
        //        return health - 20;
        //    }
        //}

        //int Kick()
        //{
        //    if (health <= 300)
        //    {
        //        return health - 20;
        //    }
        //}

        //int SpecialMove()
        //{
        //    if (health <= 300)
        //    {
        //        return health - 40;
        //    }
        //}
    }
}
