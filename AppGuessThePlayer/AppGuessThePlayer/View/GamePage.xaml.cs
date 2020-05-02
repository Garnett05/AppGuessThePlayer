using AppGuessThePlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuessThePlayer.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        public GamePage(Group group)
        {
            InitializeComponent();

            BindingContext = new ViewModel.GameViewModel(group);
        }
        public void ClickedPopupTime (object sender, EventArgs args)
        {
            Device.StartTimer(TimeSpan.FromSeconds(Database.Storage.Game.TimeGuesing + 1), () =>
            {
                DisplayAlert("Time's up", "Time has passed buddy", "Ok");
                return false;
            });
        }
    }
}