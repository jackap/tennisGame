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

        // FIXME: Rename all functions to PascalCase
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

            // TODO: Add warning message when wrong player name is typed
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

            // TODO: Introduce possibility of printing the score
            // also when there is a winner.
            public string getScore()
            {
                // FIXME: This is not an elegant solution
                String potentialWinner = getWinner();
                if ( potentialWinner != "still playing")
                {
                    return potentialWinner + " wins";
                }

                else if (bothPlayerScoredMoreThanThreePoints())
                {
                    return checkScoreAfterDeuce();
                }

                // FIXME: Extract it to a separate function to avoid confusion
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
                    // TODO: Extract it to a separate function
                    String playerInAdvantage =
                        (player1.score > player2.score) ? "player1" : "player2";
                    return "advantage " + playerInAdvantage;

                }
            }
            // FIXME: This can be extracted to a separate file
            private Boolean bothPlayerScoredMoreThanThreePoints()
            {

                return player1.score >= 3 && player2.score >= 3;

            }

            // FIXME: This can be extracted to a separate file
            private Boolean isDeuce()
            {
                return player1.score == player2.score && player1.score != 0;
            }

            // FIXME: This can be extracted to a separate file
            private Boolean isAdvantage()
            {
                return Math.Abs(player1.score - player2.score) < 2
                    && player1.score != player2.score;
            }


        }
    }
