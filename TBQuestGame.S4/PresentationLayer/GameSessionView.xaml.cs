﻿using System;
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

        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

        

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.pauseBtn_Click();
        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.playBtn_Click();
        }

        private void SpeakToButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerTalkTo();
            }
        }

        private void PunchButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerPunch();
            }
        }

        private void KickButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerKick();
            }
        }

        private void SpecialMoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationNpcsDataGrid.SelectedItem != null)
            {
                _gameSessionViewModel.OnPlayerSpecialMove();
            }
        }

        private void LocationNpcsDataGrid_AutoGeneratedColumns(object sender, EventArgs e)
        {

        }
    }
}
