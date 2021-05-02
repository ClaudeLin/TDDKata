using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePlayerPoint;
        private int _receiverPlayerPoint;

        private readonly Dictionary<int, string> _scoreStringMapping = new()
        {
            {0, "Love"},
            {1, "Fifteen"}
        };

        public string GetCurrentScore()
        {
            if ( _servicePlayerPoint != _receiverPlayerPoint)
            {
                return _scoreStringMapping[_servicePlayerPoint] + " " + _scoreStringMapping[_receiverPlayerPoint];
            }

            return _scoreStringMapping[_servicePlayerPoint] + " All";
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