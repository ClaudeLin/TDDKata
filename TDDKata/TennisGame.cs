using System;
using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePlayerScore;

        private readonly Dictionary<int, string> _scoreNameMapping = new()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        private int _receiverPlayerScore;
        private readonly string _advPlayer;

        public TennisGame(string advPlayer)
        {
            _advPlayer = advPlayer;
        }

        public string CurrentScore()
        {
            if (IsScoreDifferent())
            {
                if (_servicePlayerScore>=3 && _receiverPlayerScore>=3 &&Math.Abs(_servicePlayerScore - _receiverPlayerScore) == 1)
                {
                    if (_servicePlayerScore > _receiverPlayerScore)
                    {
                        return _advPlayer+" Adv";
                    }
                }
                return _scoreNameMapping[_servicePlayerScore] + " " + _scoreNameMapping[_receiverPlayerScore];
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private bool IsDeuce()
        {
            return _servicePlayerScore == 3;
        }

        private  string Deuce()
        {
            return "Deuce";
        }

        private bool IsScoreDifferent()
        {
            return _servicePlayerScore != _receiverPlayerScore;
        }

        private string SameScore()
        {
            return _scoreNameMapping[_servicePlayerScore] + " All";
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