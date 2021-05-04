namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePlayerScore;

        public string CurrentScore()
        {
            if (_servicePlayerScore == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void ServicePlayerGetPoint()
        {
            _servicePlayerScore++;
        }
    }
}