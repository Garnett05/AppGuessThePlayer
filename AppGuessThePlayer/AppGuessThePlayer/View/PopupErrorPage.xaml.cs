using AppGuessThePlayer.Model;
using AppGuessThePlayer.ViewModel;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
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
    public partial class PopupErrorPage : PopupPage
    {
        public PopupErrorPage(ErrorPopup errorPopup)
        {
            InitializeComponent();
            lblTitle.Text = errorPopup.Title;
            lblMessage.Text = errorPopup.Message;
            
        }
        private void ClosePage (object sender, EventArgs args)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}