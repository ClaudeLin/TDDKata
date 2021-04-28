namespace TDDKata
{
    public class TennisGame
    {
        private readonly TennisPlayer _player1;
        private readonly TennisPlayer _player2;

        public TennisGame()
        {
            _player2 = new TennisPlayer();
            _player1 = new TennisPlayer();
        }

        public string Score()
        {
            if (_player1.Score == 2)
            {
                return "Thirty Love";
            }
            if (_player1.Score == 1 && _player2.Score == 1)
            {
                return "Fifteen All";
            }
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
            _player2.GetScore();
        }
    }
}