using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TBQuestGame.Models;
using System.Windows.Shapes;

namespace TBQuestGame.PresentationLayer
{
    public partial class GameSessionView : Window
    {
        GameSessionViewModel _gameSessionViewModel;
        

        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;

            InitializeComponent();
        }

        private void quitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
