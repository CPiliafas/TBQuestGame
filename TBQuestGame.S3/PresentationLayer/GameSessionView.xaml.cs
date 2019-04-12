using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TBQuestGame.Models;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Media;

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

        private void usewaterBtn_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.UseWaterBottle();
        }

        private void useenergyBtn_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.UseEnergyDrink();
        }

        private void readDescBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
         
        }

        

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.pauseBtn_Click();
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Media.Volume = VolumeSlider.Value;
        }

        private void BalanceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Media.Balance = BalanceSlider.Value;
        }

        private void SpeedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Media.SpeedRatio = SpeedSlider.Value;
        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.playBtn_Click();
        }
    }
}
