namespace TDDKata
{
    public class TennisGame
    {
        private readonly Player _firstPlayer;

        public TennisGame()
        {
            _firstPlayer =new Player();
        }

        public string Score()
        {
            if (_firstPlayer.Score == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerGetScore()
        {
            _firstPlayer.Score++;
        }
    }
}