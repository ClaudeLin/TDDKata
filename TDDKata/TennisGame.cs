using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private int _serviceScore;
        private readonly Dictionary<int,string> _scoreStringMapping=new Dictionary<int, string>()
        {
            {0,"Love"},
            {1,"Fifteen"},
            {2,"Thirty"}
        };

        public string CurrentScore()
        {
            if (_serviceScore>0)
            {
                return _scoreStringMapping[_serviceScore] + " Love";
            }
            return "Love All";
        }

        public void ServiceGetScore()
        {
            _serviceScore++;
        }
    }
}