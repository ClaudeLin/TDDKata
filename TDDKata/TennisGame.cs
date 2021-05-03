namespace TDDKata
{
    public class TennisGame
    {
        private int _serviceScore;

        public string CurrentScore()
        {
            if (_serviceScore == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void ServiceGetScore()
        {
            _serviceScore++;
        }
    }
}