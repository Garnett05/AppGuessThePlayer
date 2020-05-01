using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;

namespace AppGuessThePlayer.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private byte _PlayerScore;
        public byte PlayerScore { get { return _PlayerScore; } set { _PlayerScore = value; OnPropertyChanged("PlayerScore"); } }
        private string _Player;
        public string Player { get { return _Player; } set { _Player = value; OnPropertyChanged("Player"); } }
        private string _CountdownPlayer;
        public string CountdownPlayer { get { return _CountdownPlayer; } set { _CountdownPlayer = value; OnPropertyChanged("CountdownPlayer"); } }
        private bool _IsVisibleContainerCountdown;
        public bool IsVisibleContainerCountdown { get { return _IsVisibleContainerCountdown; } set { _IsVisibleContainerCountdown = value; OnPropertyChanged("IsVisibleContainerCountdown"); } }
        private bool _IsVisibleContainerStart;
        public bool IsVisibleContainerStart { get { return _IsVisibleContainerStart; } set { _IsVisibleContainerStart = value; OnPropertyChanged("IsVisibleContainerStart"); } }
        private bool _IsVisiblePlayer;
        public bool IsVisiblePlayer { get { return _IsVisiblePlayer; } set { _IsVisiblePlayer = value; OnPropertyChanged("IsVisiblePlayer"); } }
        public Command ShowPlayer { get; set; }
        public Command RightAnswer { get; set; }
        public Command WrongAnswer { get; set; }
        public Command StartGame { get; set; }

        public GameViewModel()
        {
            IsVisibleContainerCountdown = false;
            IsVisibleContainerStart = false;
            IsVisiblePlayer = true;
            Player = "*************";
            ShowPlayer = new Command(SortPlayerName);
            RightAnswer = new Command(SortPlayerName);
            WrongAnswer = new Command(SortPlayerName);
            StartGame = new Command(StartAction);
        }        

        private void ShowPlayerNameAction()
        {

        }
        private void SortPlayerName()
        {
            Player = "Larry Legend";
            PlayerScore = 15;
            IsVisiblePlayer = false;
            IsVisibleContainerStart = true;
        }
        private void StartAction()
        {
            IsVisibleContainerStart = false;
            IsVisibleContainerCountdown = true;

            int i = Database.Storage.Game.TimeGuesing;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                CountdownPlayer = i.ToString();
                i--;
                return true;
            }
            );
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
