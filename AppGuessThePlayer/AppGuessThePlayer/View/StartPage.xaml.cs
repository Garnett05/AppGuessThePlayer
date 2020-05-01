using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGuessThePlayer.Model.Enum;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace AppGuessThePlayer.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            pickerLevel.ItemsSource = EnumsLevels();
            pickerRounds.ItemsSource = EnumsRounds();
        }

        public List<GameLevel> EnumsLevels()
        {
            List<GameLevel> list = new List<GameLevel>();
            foreach (GameLevel x in Enum.GetValues(typeof(GameLevel)))
                list.Add(x);
            return list;
        }
        public List<NumberOfRounds> EnumsRounds()
        {
            List<NumberOfRounds> list = new List<NumberOfRounds>();
            foreach (NumberOfRounds x in Enum.GetValues(typeof(NumberOfRounds)))
                list.Add(x);
            return list;
        }
    }
}