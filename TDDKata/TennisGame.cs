﻿using System.Collections.Generic;

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

        public string CurrentScore()
        {
            if (IsScoreDifferent())
            {
                return _scoreNameMapping[_servicePlayerScore] + " " + _scoreNameMapping[_receiverPlayerScore];
            }

            return SameScore();
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