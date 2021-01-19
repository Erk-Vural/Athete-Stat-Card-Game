using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame_1._2
{
    public class computer : Player
    {
        public computer(string playerID, string playerName, int score)
            : base(playerID, playerName, score)
        {

        }

        public computer()
        {

        }

        public Athlete SelectCard(string type, int counter)
        {
            Random rnd = new Random();
            int ind = rnd.Next(0, 4);
            List<Athlete> rCards = new List<Athlete>();

            for (int i = 7 - counter; i >= 0; i--)
            {
                if (Cards[i].getAthleteType() == type)
                {
                    rCards.Add(Cards[i]);
                }
            }
            if (ind >= rCards.Count())
            {
                ind = rCards.Count() - 1;
            }
            return rCards[ind];
        }
    }
}
