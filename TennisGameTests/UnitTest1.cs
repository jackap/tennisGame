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

        [Test]
        public void TestDeuce()
        {
            Game game = new Game();
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");

            Assert.AreEqual(game.getWinner(), "still playing");

        }

        [Test]
        public void TestAdvantagePlayer2()
        {
            Game game = new Game();
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player2");


            Assert.AreEqual(game.getWinner(), "still playing");

        }

        [Test]
        public void TestAdvantagePlayer1()
        {
            Game game = new Game();
            game.addPoint("player2"); // 0 - 15
            game.addPoint("player2"); // 0 - 30
            game.addPoint("player2"); // 0 - 40
            game.addPoint("player1"); // 15 - 40
            game.addPoint("player1"); // 30 - 40
            game.addPoint("player1"); // 40 - 40
            game.addPoint("player1"); // adv. 1

            Assert.AreEqual(game.getWinner(), "still playing");

        }
    }
}