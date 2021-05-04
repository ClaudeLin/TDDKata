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

        private int _receiverPlayerScore;

        public string CurrentScore()
        {
            if (_servicePlayerScore > 0 || _receiverPlayerScore > 0)
            {
                return scoreNameMapping[_servicePlayerScore] + " " + scoreNameMapping[_receiverPlayerScore];
            }

            return "Love All";
        }

        public void ServicePlayerGetPoint()
        {
            _servicePlayerScore++;
        }

        public void ReceiverPlayerGetPoint()
        {
            _receiverPlayerScore++;
        }
    }
}