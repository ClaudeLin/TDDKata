namespace TDDKata
{
    public class TennisGame
    {
        private readonly Player _player1;

        public TennisGame()
        {
            _player1 = new Player();
        }

        public string GetScore()
        {
            if (_player1.Point == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void Player1GetScore()
        {
            _player1.Point++;
        }
    }
}