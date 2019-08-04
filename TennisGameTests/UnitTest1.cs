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

        [Test]
        public void TestPlayer12akesAllPoints()
        {
            Game game = new Game();
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player2");

            Assert.AreEqual(game.getWinner(), "player2");

        }
    }
}