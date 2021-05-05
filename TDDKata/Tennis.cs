using System;
using System.Collections.Generic;

namespace TDDKata
{
    public class Tennis
    {
        private int _servicePlayerPoint;

        private readonly Dictionary<int, string> _scoreMapping = new()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        private int _receiverPlayerPoint;
        private readonly string _receiverPlayerName;

        public Tennis(string servicePlayerName, string receiverPlayerName)
        {
            _receiverPlayerName = receiverPlayerName;
            _servicePlayerName = servicePlayerName;
        }

        private readonly string _servicePlayerName;

        public string GetCurrentScore()
        {
            if (IsScoreDifferent())
            {
                if (IsNearGamePoint())
                {
                    if (IsAdvStatus())
                    {
                        return AdvPlayerScore();
                    }

                    return _receiverPlayerName + " Win";
                }

                return _scoreMapping[_servicePlayerPoint] + " " + _scoreMapping[_receiverPlayerPoint];
            }

            return HandleSameScore();
        }

        private bool IsNearGamePoint()
        {
            return _servicePlayerPoint > 3 || _receiverPlayerPoint > 3;
        }

        private bool IsAdvStatus()
        {
            return Math.Abs(_servicePlayerPoint - _receiverPlayerPoint) == 1;
        }

        private string AdvPlayerScore()
        {
            return (IsServicePlayerAdv() ? _servicePlayerName : _receiverPlayerName)+ " Adv";
        }

        private bool IsServicePlayerAdv()
        {
            return _servicePlayerPoint > _receiverPlayerPoint;
        }

        private string HandleSameScore()
        {
            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private string Deuce()
        {
            return "Deuce";
        }

        private string SameScore()
        {
            return _scoreMapping[_servicePlayerPoint] + " All";
        }

        private bool IsDeuce()
        {
            return _servicePlayerPoint >= 3;
        }

        private bool IsScoreDifferent()
        {
            return _receiverPlayerPoint != _servicePlayerPoint;
        }

        public void ServicePlayerGetPoint()
        {
            _servicePlayerPoint++;
        }

        public void ReceiverPlayerGetPoint()
        {
            _receiverPlayerPoint++;
        }
    }
}