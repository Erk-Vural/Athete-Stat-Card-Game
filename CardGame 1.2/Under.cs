using System.Drawing;

namespace CardGame_1._2
{
    class Under : Athlete
    {
        private int penalty;
        private int freeKick;
        private int faceTheGoalKeeper;

        public Under(string footballerName, string footballerTeam, string type,
            int penalty, int freeKick, int faceTheGoalKeeper)
                : base(footballerName, footballerTeam, type)
        {
            this.penalty = penalty;
            this.freeKick = freeKick;
            this.faceTheGoalKeeper = faceTheGoalKeeper;
            this.athleteImage = Image.FromFile("images\\under.jpg");
        }

        public Under()
        {
            setAthleteName("footballer Name");
            setAthleteTeam("football Team");
            penalty = 0;
            freeKick = 0;
            faceTheGoalKeeper = 0;
        }

        public int getPenalty()
        {
            return penalty;
        }

        public void setPenalty(int penalty)
        {
            this.penalty = penalty;
        }

        public int getFreeKick()
        {
            return freeKick;
        }

        public void setFreeKick(int freeKick)
        {
            this.freeKick = freeKick;
        }

        public int getFaceTheGoalKeeper()
        {
            return faceTheGoalKeeper;
        }

        public void setFaceTheGoalKeeper(int faceTheGoalKeeper)
        {
            this.faceTheGoalKeeper = faceTheGoalKeeper;
        }

        public override string ShowAthletePoint()
        {
            return "Penalty =                         " + penalty
                + " \nFree Kick =                      " + freeKick
                + " \nFace the goal keeper = " + faceTheGoalKeeper;
        }

        public override int SendAthleteValue(int spec)
        {
            if (spec == 1)
            {
                return penalty;
            }
            else if (spec == 2)
            {
                return freeKick;
            }
            else
            {
                return faceTheGoalKeeper;
            }
        }
    }

}
