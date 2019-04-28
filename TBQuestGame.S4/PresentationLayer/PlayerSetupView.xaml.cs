using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TBQuestGame.Models;

namespace TBQuestGame.PresentationLayer
{
    public partial class PlayerSetupView : Window
    {
        private Player _player;

        public PlayerSetupView(Player player)
        {
            _player = player;

            InitializeComponent();

            SetupWindow();
        }

        private void SetupWindow()
        {
            //
            // generates lists for each enum to use in the combo boxes
            //
            List<string> specialMoves = Enum.GetNames(typeof(Player.SpecialMoveName)).ToList();
            SpecialMoveComboBox.ItemsSource = specialMoves;
            //List<string> gender = Enum.GetNames(typeof(Player.Gender)).ToList();
            //GenderComboBox.ItemsSource = gender;

            //
            // hide error message box when initialized
            //
            ErrorMessageTextBlock.Visibility = Visibility.Hidden;
        }

        private bool IsValidInput(out string errorMessage)
        {
            errorMessage = "";

            if (NameTextBox.Text == "")
            {
                errorMessage += "Player Name is required.\n";
            }
            else
            {
                _player.Name = NameTextBox.Text;
                
            }

            return errorMessage == "" ? true : false;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage;

            if (IsValidInput(out errorMessage))
            {
                //
                // get value from combo box
                //
                Enum.TryParse(SpecialMoveComboBox.SelectionBoxItem.ToString(), out Player.SpecialMoveName specialMove);

                //
                // set player properties
                //

                //Player.SpecialMove = Specialmove;

                Visibility = Visibility.Hidden;
            }
            else
            {
                //
                // display error messages
                //
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
                ErrorMessageTextBlock.Text = errorMessage;
            }
        }
    }
}
