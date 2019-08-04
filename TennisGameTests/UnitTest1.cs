using NUnit.Framework;
using TennisGame;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPlayer1MakesAllPoints()
        {
            Game game = new Game();
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");

            Assert.AreEqual(game.getWinner(), "player1");

        }
    }
}