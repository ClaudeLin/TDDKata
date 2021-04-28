namespace TDDKata
{
    public class TennisGame
    {
        private readonly TennisPlayer _player1;

        public TennisGame()
        {
            _player1 = new TennisPlayer();
        }

        public string Score()
        {
            if (_player1.Score == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerGetScore()
        {
            _player1.GetScore();
        }

        public void SecondPlayerGetScore()
        {
        }
    }
}