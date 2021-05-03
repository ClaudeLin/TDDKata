using System;
using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private int _serviceScore;
        private int _receiverScore;

        private readonly Dictionary<int, string> _scoreStringMapping = new()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };


        public string CurrentScore()
        {
            if (_serviceScore != _receiverScore)
            {
                if (_serviceScore >=3  )
                {
                    if ((_serviceScore - _receiverScore) == 1)
                    {
                        return "Service Adv";
                    }
                }
                if (_serviceScore > 0 || _receiverScore > 0)
                {
                    return _scoreStringMapping[_serviceScore] + " " + _scoreStringMapping[_receiverScore];
                }
            }

            if (_serviceScore >= 3)
            {
                return "Deuce";
            }
            return SameScore();
        }

        private string SameScore()
        {
            return _scoreStringMapping[_serviceScore] + " All";
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