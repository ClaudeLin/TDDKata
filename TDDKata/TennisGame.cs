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

            if (_servicePoint == 2)
            {
                return "Thirty Love";
            }
            return "Love ALl";
        }

        public void ServiceGetPoint()
        {
            _servicePoint++;
        }
    }
}