using System;
using System.Linq;
using System.Collections.Generic;

namespace Katas
{
    public class RockPaperScissors
    {
        static void Main(string[] args)
        {
        }

        public string determineWinner(string gesture1, string gesture2){
            ValidateGestureName(gesture1); ValidateGestureName(gesture2);
            
            var _gesture1 = gesture1.ToLower();
            var _gesture2 = gesture2.ToLower();

            if (_gesture1 == _gesture2) return "Tie!";

            if (_gesture1 == "rock" && _gesture2 == "scissors") 
                return $"{gesture1} beats {gesture2}";

            if (_gesture1 == "scissors" && _gesture2 == "paper")
                return $"{gesture1} beats {gesture2}";

            return null;
        }

        private void ValidateGestureName(string gesture) {
            if (string.IsNullOrWhiteSpace(gesture)) 
                throw new ArgumentException("Gesture name is null or whitespace.");

            if (!"|rock|paper|scissors|".Contains($"|{gesture.ToLower()}|")) 
                throw new ArgumentException($"Invalid gesture name: {gesture}");
        }
    }
}
