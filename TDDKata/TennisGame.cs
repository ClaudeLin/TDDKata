using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private int _serviceScore;
        private int _receiverScore;
        private readonly Dictionary<int,string> _scoreStringMapping=new()
        {
            {0,"Love"},
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };


        public string CurrentScore()
        {
            if (_serviceScore>0 || _receiverScore>0)
            {
                return _scoreStringMapping[_serviceScore] + " "+_scoreStringMapping[_receiverScore];
            }

            return "Love All";
        }

        public void ServiceGetScore()
        {
            _serviceScore++;
        }

        public void ReceiverGetScore()
        {
            _receiverScore++;
        }
    }
}