using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private readonly TennisPlayer _player1;
        private readonly TennisPlayer _player2;
        private Dictionary<int,string> scoreMapping ;

        public TennisGame()
        {
            scoreMapping = new Dictionary<int, string>()
            {
                {0,"Love"},
                {1,"Fifteen"},
                {2,"Thirty"},
            };
            _player2 = new TennisPlayer();
            _player1 = new TennisPlayer();
        }

        public string Score()
        {
            
            if (_player1.Score == 2 && _player2.Score!=_player1.Score)
            {
                return scoreMapping[_player1.Score] + " " + scoreMapping[_player2.Score];
            }
            if (_player1.Score == 1 && _player2.Score!=_player1.Score)
            {
                return scoreMapping[_player1.Score] + " " + scoreMapping[_player2.Score];
            }

            if (_player1.Score == _player2.Score)
            {
                return scoreMapping[_player1.Score] + " All";
            }
            
            return "Love All";
        }

        public void FirstPlayerGetScore()
        {
            _player1.GetScore();
        }

        public void SecondPlayerGetScore()
        {
            _player2.GetScore();
        }
    }
}