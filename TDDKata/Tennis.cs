using System.Collections.Generic;

namespace TDDKata
{
    public class Tennis
    {
        private int _servicePlayerPoint;
        private Dictionary<int,string> _scoreMapping=new Dictionary<int, string>()
        {
            {0,"Love"},
            {1,"Fifteen"},
            {2,"Thirty"},
            {3,"Forty"}
        };

        public string GetCurrentScore()
        {
            if (_servicePlayerPoint > 0)
            {
                return _scoreMapping[_servicePlayerPoint] + " Love";
            }

            return "Love All";
        }

        public void ServicePlayerGetPoint()
        {
            _servicePlayerPoint++;
        }
    }
}