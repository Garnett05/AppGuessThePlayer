using AppGuessThePlayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGuessThePlayer.Database
{
    public class Storage
    {
        public static Game Game { get; set; }
        public static short Currentround { get; set; }
    }
}
