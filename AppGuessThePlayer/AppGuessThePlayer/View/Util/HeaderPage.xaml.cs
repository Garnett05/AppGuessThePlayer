using AppGuessThePlayer.Database;
using AppGuessThePlayer.Model;
using AppGuessThePlayer.ViewModel;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuessThePlayer.View.Util
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderPage : ContentView
    {        
        public HeaderPage()
        {
            InitializeComponent();
            BindingContext = new HeaderViewModel();
        }

        private void RestartAction(object sender, EventArgs args)
        {
            var viewModel = (ViewModel.HeaderViewModel)this.BindingContext;
            if (viewModel.Restart.CanExecute(null))
            {
                viewModel.Restart.Execute(null);
            }
        }
    }
}