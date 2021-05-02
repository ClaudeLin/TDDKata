namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePlayerPoint;

        public string GetCurrentScore()
        {
            if (_servicePlayerPoint == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void ServicePlayerGetPoint()
        {
            _servicePlayerPoint++;
        }

        public void ReceiverPlayerGetPoint()
        {
            
        }
    }
}