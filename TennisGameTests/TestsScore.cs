using NUnit.Framework;
using TennisGame;

namespace Tests
{
    public class TestsScore
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLoveLove()
        {
            Game game = new Game();
            
            Assert.AreEqual(game.getScore(), "love - love");

        }

        [Test]
        public void TestFifteenLove()
        {
            Game game = new Game();
            game.addPoint("player1");


            Assert.AreEqual(game.getScore(), "fifteen - love");

        }

        [Test]
        public void TestThirtyLove()
        {
            Game game = new Game();
            game.addPoint("player1");
            game.addPoint("player1");



            Assert.AreEqual(game.getScore(), "thirty - love");

        }

        [Test]
        public void TestFortyLove()
        {
            Game game = new Game();
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");



            Assert.AreEqual(game.getScore(), "forty - love");

        }

        [Test]
        public void TestDeuce()
        {
            Game game = new Game();
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player2");



            Assert.AreEqual(game.getScore(), "deuce");

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
            game.addPoint("player2");


            Assert.AreEqual(game.getScore(), "advantage player2");

        }

        [Test]
        public void TestAdvantagePlayer1()
        {
            Game game = new Game();
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player2");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");


            Assert.AreEqual(game.getScore(), "advantage player1");

        }

        [Test]
        public void TestWinPlayer1()
        {
            Game game = new Game();
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");
            game.addPoint("player1");


            Assert.AreEqual(game.getScore(), "player1 wins");

        }
    }
}