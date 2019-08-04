using System;
namespace TennisGame
{

    enum Points
    {
        love,
        fifteen,
        thirty,
        forty
    }

    public class Game
    {
        private Player player1;
        private Player player2;

        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            player1.name = "player1";
            player1.score = 0;
            player2.name = "player2";
            player2.score = 0;

        }

        public void addPoint(string playerName)
        {
            if (playerName == "player1")
            {
                player1.score++;
            }
            else if (playerName == "player2")
            {
                player2.score++;
            }
        }

        public string getWinner()
        {
            if (bothPlayerScoredMoreThanThreePoints())
            {
                return checkWinnerAfterDeuce();
            }
            else
                return checkWinnerWhenNoDeuce();

        }

        private string checkWinnerAfterDeuce()
        {
            if (isDeuce() || isAdvantage())
                return "still playing";

            else if (player1.score > player2.score)
                return "player1";
            else
                return "player2";
        }

        private string checkWinnerWhenNoDeuce()
        {
            if (player1.score > 3)
                return "player1";
            else if (player2.score > 3)
                return "player2";
            else
                return "still playing";
        }

        public string getScore()
        {
            if (bothPlayerScoredMoreThanThreePoints())
            {
                return checkScoreAfterDeuce();
            }

            else
                return Enum.GetName(typeof(Points), player1.score)
                    + " - "
                    + Enum.GetName(typeof(Points), player2.score);
        }


        private string checkScoreAfterDeuce()
        {
            if (isDeuce())
            {
                return "deuce";
            }
            else
            {
                String playerInAdvantage =
                    (player1.score > player2.score) ? "player1" : "player2";
                return "advantage " + playerInAdvantage;

            }
        }

        private Boolean bothPlayerScoredMoreThanThreePoints()
        {

            return player1.score >= 3 && player2.score >= 3;

        }

        private Boolean isDeuce()
        {
            return player1.score == player2.score && player1.score != 0;
        }

        private Boolean isAdvantage()
        {
            return Math.Abs(player1.score - player2.score) < 2
                && player1.score != player2.score;
        }


    }
}
