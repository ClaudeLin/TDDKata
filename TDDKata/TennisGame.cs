namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePoint;

        public string CurrentScore()
        {
            if (_servicePoint == 1)
            {
                return "Fifteen Love";
            }
            return "Love ALl";
        }

        public void ServiceGetPoint()
        {
            _servicePoint++;
        }
    }
}