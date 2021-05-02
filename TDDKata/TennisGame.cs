namespace TDDKata
{
    public class TennisGame
    {
        private int _servicePlayerPoint;
        private int _receiverPlayerPoint;

        public string GetCurrentScore()
        {
            if (_servicePlayerPoint==1 && _servicePlayerPoint == _receiverPlayerPoint)
            {
                return "Fifteen All";
            }
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
            _receiverPlayerPoint++;
        }
    }
}