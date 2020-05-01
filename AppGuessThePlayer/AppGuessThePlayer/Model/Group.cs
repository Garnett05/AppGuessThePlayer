using System;
using System.Collections.Generic;
using System.Text;

namespace AppGuessThePlayer.Model
{
    public class Group
    {
        public string Name { get; set; }
        public short Score { get; set; }

        public Group()
        {
        }
        public Group (string name, short score)
        {
            Name = name;
            Score = score;
        }        
    }
}
