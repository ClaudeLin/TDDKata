﻿using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePlayerPoint;
        private int _receiverPlayerPoint;

        private readonly Dictionary<int, string> _scoreStringMapping = new()
        {
            {
                0, "Love"
            },
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public string GetCurrentScore()
        {
            if (_servicePlayerPoint < 4 && _servicePlayerPoint != _receiverPlayerPoint)
            {
                return _scoreStringMapping[_servicePlayerPoint] + " " + _scoreStringMapping[_receiverPlayerPoint];
            }

            if (_servicePlayerPoint == 4 && _receiverPlayerPoint == 3)
            {
                return "Service Player Adv.";
            }

            if (_servicePlayerPoint == 3)
            {
                return "Deuce";
            }

            return _scoreStringMapping[_servicePlayerPoint] + " All";
        }

        public void ServicePlayerGetPoint(int point = 1)
        {
            _servicePlayerPoint += point;
        }

        public void ReceiverPlayerGetPoint(int point = 1)
        {
            _receiverPlayerPoint += point;
        }
    }
}