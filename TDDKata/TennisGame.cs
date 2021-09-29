using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _scoreMapping = new()
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        private int _receiverPoint;

        private int _servicePoint;

        public string CurrentScore()
        {
            if (_servicePoint !=_receiverPoint)
            {
                return $"{_scoreMapping[_servicePoint]} {_scoreMapping[_receiverPoint]}";
            }

            return $"{_scoreMapping[_servicePoint]} All";
        }

        public void ServiceGetPoint(int times = 1)
        {
            for (var i = 0; i < times; i++)
            {
                _servicePoint++;
            }
        }

        public void ReceiverGetPoint()
        {
            _receiverPoint++;
        }
    }
}