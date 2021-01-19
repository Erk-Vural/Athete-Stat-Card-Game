using System.Drawing;

namespace CardGame_1._2
{
    public abstract class Athlete
    {
        private string athleteName;
        private string athleteTeam;
        private string athleteType;
        public Image athleteImage;


        public Athlete(string athleteName, string athleteTeam, string athleteType)
        {
            this.athleteName = athleteName;
            this.athleteTeam = athleteTeam;
            this.athleteType = athleteType;

        }

        public Athlete()
        {

        }

        public string getAthleteName()
        {
            return athleteName;
        }

        public void setAthleteName(string athleteName)
        {
            this.athleteName = athleteName;
        }


        public string getAthleteTeam()
        {
            return athleteTeam;
        }

        public void setAthleteTeam(string athleteTeam)
        {
            this.athleteTeam = athleteTeam;
        }

        public string getAthleteType()
        {
            return athleteType;
        }

        public void setAthleteType(string athleteType)
        {
            this.athleteType = athleteType;
        }

        public Image getAthleteImage()
        {
            return athleteImage;
        }

        public void setAthleteImage(Image athleteImage)
        {
            this.athleteImage = athleteImage;
        }

        public abstract string ShowAthletePoint();

        public abstract int SendAthleteValue(int spec);
    }
}
