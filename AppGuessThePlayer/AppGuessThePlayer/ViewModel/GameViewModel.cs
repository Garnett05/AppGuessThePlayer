using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using AppGuessThePlayer.Model;

namespace AppGuessThePlayer.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public Group Group { get; set; }
        private byte _GameScore;
        public string NameGroup { get; set; }
        public byte GameScore { get { return _GameScore; } set { _GameScore = value; OnPropertyChanged("GameScore"); } }
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

        public GameViewModel(Group group)
        {
            Group = group;
            NameGroup = group.Name;

            IsVisibleContainerCountdown = false;
            IsVisibleContainerStart = false;
            IsVisiblePlayer = true;
            Player = "*************";
            ShowPlayer = new Command(SortPlayerName);
            RightAnswer = new Command(RightAnswerAction);
            WrongAnswer = new Command(WrongAnswerAction);
            StartGame = new Command(StartAction);
        }        

        private void ShowPlayerNameAction()
        {

        }
        private void SortPlayerName()
        {
            Player = "Larry Legend";
            GameScore = 15;
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
        private void RightAnswerAction()
        {
            Group.Score += GameScore;
            GoNextGroup();
        }
        private void WrongAnswerAction()
        {
            GoNextGroup();
        }        

        public void GoNextGroup()
        {
            Group group;
            if (Database.Storage.Game.Group1 == Group)
            {
                group = Database.Storage.Game.Group2;                
            }
            else
            {
                group = Database.Storage.Game.Group1;
                Database.Storage.Currentround++;
            }
            if (Database.Storage.Currentround > Database.Storage.Game.Rounds)
            {
                App.Current.MainPage = new View.ResultPage();
            }
            else
            {
                App.Current.MainPage = new View.GamePage(group);
            }            
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
