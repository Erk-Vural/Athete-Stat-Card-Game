using System.Drawing;

namespace CardGame_1._2
{
    class Hido : Athlete
    {
        private int twoPointer;
        private int threePointer;
        private int freeThrow;

        public Hido(string basketballerName, string basketballerTeam, string type,
         int twoPointer, int threePointer, int freeThrow)
             : base(basketballerName, basketballerTeam, type)
        {
            this.twoPointer = twoPointer;
            this.threePointer = threePointer;
            this.freeThrow = freeThrow;
            this.athleteImage = Image.FromFile("images\\hido.jpg");
        }

        public Hido()
        {
            setAthleteName("basketballer Name");
            setAthleteTeam("basketballer Team");
            twoPointer = 0;
            threePointer = 0;
            freeThrow = 0;
        }

        public int getTwoPointer()
        {
            return twoPointer;
        }

        public void setTwoPointer(int twoPointer)
        {
            this.twoPointer = twoPointer;
        }

        public int getThreePointer()
        {
            return threePointer;
        }

        public void setThreePinter(int threePointer)
        {
            this.threePointer = threePointer;
        }

        public int getFreeThrow()
        {
            return freeThrow;
        }

        public void setFreeThrow(int freeThrow)
        {
            this.freeThrow = freeThrow;
        }

        public override string ShowAthletePoint()
        {
            return "Two pointer =    " + twoPointer
                + "\nThree pointer = " + threePointer
                + "\nFree throw =      " + freeThrow;
        }

        public override int SendAthleteValue(int spec)
        {
            if (spec == 1)
            {
                return twoPointer;
            }
            else if (spec == 2)
            {
                return threePointer;
            }
            else
            {
                return freeThrow;
            }
        }
    }
}
