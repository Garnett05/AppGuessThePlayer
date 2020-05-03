using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppGuessThePlayer.ViewModel
{
    public class HeaderViewModel
    {
        public Command Restart { get; set; }
        

        public HeaderViewModel()
        {
            Restart = new Command(RestartAction);
        }

        private void RestartAction()
        {
            App.Current.MainPage = new View.StartPage();
        }
    }
}
