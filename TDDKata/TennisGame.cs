using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePlayerScore;

        private Dictionary<int, string> scoreNameMapping = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public string CurrentScore()
        {
            if (_servicePlayerScore > 0)
            {
                return scoreNameMapping[_servicePlayerScore] + " Love";
            }

            return "Love All";
        }

        public void ServicePlayerGetPoint()
        {
            _servicePlayerScore++;
        }
    }
}