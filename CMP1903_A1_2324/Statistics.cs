using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class statistics
    {
        //Properties
        private int sevensOutBegun;
        private int sevensOutComplete;
        private int sevensOutHighScore;

        private int threeOrMoreBegun;
        private int threeOrMoreComplete;
        private int threeOrMoreHighScore;

        public statistics()
        {
            console.WriteLine("\n\nGame statistics:\nNumber of times Sevens Out has been started: " + sevensOutBegun + "\nNumber of times Sevens Out has been completed: " + sevensOutComplete + "\nSevens Out high score: " + sevensOutHighScore);
            console.WriteLine("Number of times Three or More has been started: " + threeOrMoreBegun + "\nNumber of times Three or More has been completed: " + threeOrMoreComplete + "\nThree or More high score: " + sevensOutHighScore);
        }

        public void sevensOutBegin() { evensOutBegun++; } //Upon being called, the appropriate variable is incrimented
        public void sevensOutCompleted() { sevensOutComplete++; }

        public void threeOrMoreBegin() { threeOrMoreBegun++; }
        public void threeOrMoreCompleted() { threeOrMoreComplete++; }
    }
}

