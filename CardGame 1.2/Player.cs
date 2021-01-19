using System.Collections.Generic;

namespace CardGame_1._2
{
    public abstract class Player
    {
        private string playerID;
        private string playerName;
        private int score;
        public List<Athlete> Cards = new List<Athlete>();

        public Player(string playerID, string playerName, int score)
        {
            this.playerID = playerID;
            this.playerName = playerName;
            this.score = 0;
        }

        public Player()
        {

        }

        public string getPlayerID()
        {
            return playerID;
        }

        public void setPlayerID(string ID)
        {
            this.playerID = ID;
        }

        public string getPlayerName()
        {
            return playerName;
        }

        public void setPlayerName(string name)
        {
            this.playerName = name;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public int showScore()
        {
            return score;
        }

        public void setCards(Athlete setCard)
        {
            Cards.Add(setCard);
        }
    }
}
