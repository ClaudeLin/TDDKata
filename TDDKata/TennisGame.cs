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

        private readonly string _servicePlayerName;
        private readonly string _receiverPlayerName;

        public TennisGame(string servicePlayerName, string receiverPlayerName)
        {
            _servicePlayerName = servicePlayerName;
            _receiverPlayerName = receiverPlayerName;
        }


        public string CurrentScore()
        {
            if (IsScoreDifferent())
            {
                if (IsNearGamePoint())
                {
                    if (Math.Abs(_serviceScore - _receiverScore) == 1)
                    {
                        return AdvPlayer() + " Adv";
                    }
                }

                return _scoreStringMapping[_serviceScore] + " " + _scoreStringMapping[_receiverScore];
            }

            return IsDeuce() ? Deuce() : SameScore();
        }

        private bool IsNearGamePoint()
        {
            return _serviceScore >= 3;
        }

        private string AdvPlayer()
        {
            return _serviceScore > _receiverScore ? _servicePlayerName : _receiverPlayerName;
        }

        private bool IsScoreDifferent()
        {
            return _serviceScore != _receiverScore;
        }

        private string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _serviceScore >= 3;
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