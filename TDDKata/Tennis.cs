using System.Collections.Generic;

namespace TDDKata
{
    public class Tennis
    {
        private int _servicePlayerPoint;
        private readonly Dictionary<int,string> _scoreMapping=new()
        {
            {0,"Love"},
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        private int _receiverPlayerPoint;

        public string GetCurrentScore()
        {
            if (IsScoreDifferent())
            {
                return _scoreMapping[_servicePlayerPoint]+ " " + _scoreMapping[_receiverPlayerPoint];
            }

            return _scoreMapping[_servicePlayerPoint] +" All";
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