using System;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void RockShouldCrushScissors() {
            RockPaperScissors game = new RockPaperScissors();
            Assert.AreEqual("rock beats scissors", game.determineWinner("rock", "scissors"));
            Assert.AreEqual("rock beats scissors", game.determineWinner("scissors", "rock"));
        }

        [Test]
        public void ScissorsShouldBeatPaper()
        {
            RockPaperScissors game = new RockPaperScissors();
            Assert.AreEqual("scissors beats paper", game.determineWinner("scissors", "paper"));
            Assert.AreEqual("scissors beats paper", game.determineWinner("paper", "scissors"));
        }

        [Test]
        public void CheckForTiesAndCaseSensitivity()
        {
            RockPaperScissors game = new RockPaperScissors();
            Assert.AreEqual("Tie!", game.determineWinner("rock", "ROCK"));
            Assert.AreEqual("Tie!", game.determineWinner("SCISSORS", "SciSsOrs"));
            Assert.AreEqual("Tie!", game.determineWinner("paPer", "paper"));
        }

        [Test]
        public void InvalidGesturesShouldThrowAnException() {
            var _game = new RockPaperScissors();
            
            //Spelling issues
            Assert.Catch<ArgumentException>(() => _game.determineWinner("scisors", "rock"), "Invalid gesture name: scisors");
            Assert.Catch<ArgumentException>(() => _game.determineWinner("scissors", "roc"), "Invalid gesture name: roc");

            //Null or Whitespace
            Assert.Catch<ArgumentException>(() => _game.determineWinner(null, "scissors"), "Gesture name is null or whitespace.");
            Assert.Catch<ArgumentException>(() => _game.determineWinner("", "scissors"), "Gesture name is null or whitespace.");
            Assert.Catch<ArgumentException>(() => _game.determineWinner("rock", null), "Gesture name is null or whitespace.");
            Assert.Catch<ArgumentException>(() => _game.determineWinner("rock", ""), "Gesture name is null or whitespace.");
        }

    }
}