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
        private readonly string _servicePlayer;
        private readonly string _receiverPlayer;

        public TennisGame(string servicePlayer, string receiverPlayer)
        {
            _servicePlayer = servicePlayer;
            _receiverPlayer = receiverPlayer;
        }

        public string CurrentScore()
        {
            if (IsScoreDifferent())
            {
                if (_servicePlayerScore>=3 && _receiverPlayerScore>=3 &&Math.Abs(_servicePlayerScore - _receiverPlayerScore) == 1)
                {
                    return AdvPlayer();
                }
                return _scoreNameMapping[_servicePlayerScore] + " " + _scoreNameMapping[_receiverPlayerScore];
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private string AdvPlayer()
        {
            return AdvPlayerName(IsServicePlayerHasAdv() ? _servicePlayer : _receiverPlayer);
        }

        private bool IsReceiverPlayerHasAdv()
        {
            return _receiverPlayerScore > _servicePlayerScore;
        }

        private string AdvPlayerName(string advPlayer)
        {
            return advPlayer + " Adv";
        }

        private bool IsServicePlayerHasAdv()
        {
            return _servicePlayerScore > _receiverPlayerScore;
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