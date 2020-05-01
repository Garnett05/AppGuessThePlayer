using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppGuessThePlayer.ViewModel
{
    public class GameViewModel
    {
        public byte PlayerScore { get; set; }
        public string Player { get; set; }        
        public bool ContainerCountdown { get; set; }
        public bool ContainerStart { get; set; }
        public string CountdownPlayer { get; set; }
        public Command ShowPlayer { get; set; }
        public Command RightAnswer { get; set; }
        public Command WrongAnswer { get; set; }
        public Command StartGame { get; set; }

        public GameViewModel()
        {
            ContainerCountdown = false;
            ShowPlayer = new Command();
            RightAnswer = new Command();
            WrongAnswer = new Command();
            StartGame = new Command();
        }

    }
}
