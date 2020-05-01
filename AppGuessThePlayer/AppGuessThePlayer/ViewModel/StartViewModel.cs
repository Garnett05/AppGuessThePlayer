using System;
using System.Collections.Generic;
using System.Text;
using AppGuessThePlayer.Model;
using System.ComponentModel;
using Xamarin.Forms;
using AppGuessThePlayer.Database;

namespace AppGuessThePlayer.ViewModel
{
    public class StartViewModel : INotifyPropertyChanged
    {
        public Game Game { get; set; }
        public Command StartCommand { get; set; }
        public StartViewModel()
        {
            StartCommand = new Command(StartGame);
        }
        private void StartGame()
        {
            Storage.Game = this.Game;
            Storage.Currentround = 1;
            App.Current.MainPage = new View.GamePage();
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
