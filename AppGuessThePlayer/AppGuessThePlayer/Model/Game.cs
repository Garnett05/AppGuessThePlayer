using System;
using System.Collections.Generic;
using System.Text;
using AppGuessThePlayer.Model.Enum;

namespace AppGuessThePlayer.Model
{
    public class Game
    {
        public Group Group1 { get; set; }
        public Group Group2 { get; set; }
        public GameLevel Level { get; set; }
        public int NumericLevel { get; set; }
        public short TimeGuesing { get; set; }
        public short Rounds { get; set; }

    }
}
