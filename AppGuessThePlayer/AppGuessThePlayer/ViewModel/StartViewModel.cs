using System;
using System.Collections.Generic;
using System.Text;
using AppGuessThePlayer.Model;
using System.ComponentModel;
using Xamarin.Forms;
using AppGuessThePlayer.Database;
using AppGuessThePlayer.View;
using Rg.Plugins.Popup.Services;

namespace AppGuessThePlayer.ViewModel
{
    public class StartViewModel : INotifyPropertyChanged
    {
        public Game Game { get; set; }        
        public Command StartCommand { get; set; }
        public StartViewModel()
        {
            StartCommand = new Command(StartGame);
            //Necessário instanciar para os objetos não ficarem como null nas telas seguintes
            Game = new Game();
            Game.Group1 = new Group();
            Game.Group2 = new Group();
        }
        private void StartGame()
        {
            if (Game.TimeGuesing < 10 != Game.TimeGuesing > 180)
            {
                ErrorPopup error = new ErrorPopup();
                error.Title = "Error!";
                error.Message = "The time should be between 10 and 180 seconds.";
                var nextPage = new PopupErrorPage(error);
                PopupNavigation.Instance.PushAsync(nextPage);
            }
            else
            {
                Storage.Game = this.Game;
                Storage.Currentround = 1;
                App.Current.MainPage = new View.GamePage(Game.Group1);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string nameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameProperty));
            }
        }
    }
}
