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

            if (_serviceScore == 2)
            {
                return "Thirty Love";
            }
            return "Love All";
        }

        public void ServiceGetScore()
        {
            _serviceScore++;
        }
    }
}