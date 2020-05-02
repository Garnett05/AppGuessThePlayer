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
        public static string[][] Players =
        {
            // One point
            new string[] {"Larry Legend", "Bill Russell", "Kevin Garnett", "Paul Pierce", "Kevin McHale", "John Havlicek", "Bob Cousy"},
            // Three points
            new string[] {"Tony Allen", "Nate Robinson", "Jae Crowder", "Kendrick Perkins", "Jaylen Brown", "Jayson Tatum", "Rajon Rondo", "Antoine Walker"},
            // Five points
            new string[] {"Jonas Jerebko", "Delonte West", "Amir Johnson", "Gerald Wallace", "Rick Carlisle", "Walter McCarty", "Dana Barros", "Eddie House"}
        };
    }
}
