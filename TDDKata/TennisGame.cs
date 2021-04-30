using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private readonly Player _service;
        private readonly Player _receiver;

        private readonly Dictionary<int, string> _scoreMapping = new()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"}
        };

        public TennisGame()
        {
            _receiver = new Player();
            _service = new Player();
        }

        public string GetScore()
        {
            if (_service.Point == 1 && _service.Point != _receiver.Point)
            {
                return _scoreMapping[_service.Point] + " " + _scoreMapping[_receiver.Point];
            }

            if (_service.Point == 2 && _service.Point != _receiver.Point)
            {
                return _scoreMapping[_service.Point] + " " + _scoreMapping[_receiver.Point];
            }

            return _scoreMapping[_service.Point] + " All";
        }

        public void ServiceGetScore()
        {
            _service.Point++;
        }

        public void ReceiverGetScore()
        {
            _receiver.Point++;
        }
    }
}