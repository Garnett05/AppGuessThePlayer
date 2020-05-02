using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using AppGuessThePlayer.Model;
using Xamarin.Forms;

namespace AppGuessThePlayer.ViewModel
{
    public class ResultViewModel : INotifyPropertyChanged
    {
        public Game Game { get; set; }
        public Command PlayAgain { get; set; }
        public ResultViewModel()
        {
            Game = Database.Storage.Game;
            PlayAgain = new Command(PlayNewGame);
        }

        private void PlayNewGame()
        {
            App.Current.MainPage = new View.StartPage();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
