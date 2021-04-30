namespace TDDKata
{
    public class TennisGame
    {
        private readonly Player _player1;
        private readonly Player _receiver;

        public TennisGame()
        {
            _receiver = new Player();
            _player1 = new Player();
        }

        public string GetScore()
        {
            if (_player1.Point == 1 && _receiver.Point == 1)
            {
                return "Fifteen All";
            }
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

        public void ReceiverGetScore()
        {
            _receiver.Point++;
        }
    }
}