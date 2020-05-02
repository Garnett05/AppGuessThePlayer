using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppGuessThePlayer.View.Util
{
    public class Converter : IValueConverter
    {
        //View -> ViewModel
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            short score = short.Parse(value.ToString());
            if(score == 0)
            {
                return "";
            }
            else
            {
                return "Player answer value: " + score;
            }            
        }

        //ViewModel -> View
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
