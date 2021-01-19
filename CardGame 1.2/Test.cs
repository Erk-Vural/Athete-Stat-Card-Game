using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CardGame_1._2
{
    public partial class Test : Form
    {
        List<Athlete> b_cards = new List<Athlete>();
        List<Athlete> f_cards = new List<Athlete>();
        public computer computer_player;
        public User human_player;

        int selected_card = 0;
        int counter = 0;
        int h_score = 0;
        int c_score = 0;

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            human_player = new User("1", "Player_1", 0);
            computer_player = new computer("2", "Player_2", 0);

            DefineCards();
            DistributeCards();

            game_over_lbl.Visible = false;
            player_wins.Visible = false;

            athletePoint();
            athleteName();
            athletePicture();

            playerScore(h_score, c_score);
        }

        public void DefineCards()
        {
            Asik asik;
            Cedi cedi;
            Dogus dogus;
            Erden erden;
            Ersan ersan;
            Furkan furkan;
            Hido hido;
            Memet memet;

            Hazard hazard;
            Maradona maradona;
            Messi messi;
            Ronaldo ronaldo;
            Modric modric;
            Ozil ozil;
            Neymar neymar;
            Under under;

            asik = new Asik("Omer Asik", "Chicago Bulls", "Basketballer", 78, 74, 72);
            cedi = new Cedi("Cedi Osman", "Cleveland Cavaliers", "Basketballer", 76, 80, 72);
            dogus = new Dogus("Dogus Balbay", "Anadolu Efes", "Basketballer", 78, 76, 78);
            ersan = new Ersan("Ersan Ilyasova", "Milwaukee Bucks", "Basketballer", 76, 80, 81);
            erden = new Erden("Semih Erden", "Anadolu Efes", "Basketballer", 76, 74, 73);
            furkan = new Furkan("Furkan Korkmaz", "Philadelphia 76ers", "Basketballer", 80, 90, 81);
            hido = new Hido("Hedo Turkoglu", "Sacramento Kings", "Basketballer", 80, 74, 77);
            memet = new Memet("Memet Okur", "Utah Jazz", "Basketballer", 77, 80, 79);

            hazard = new Hazard("Eden Hazard", "Real Madrid", "Footballer", 86, 83, 81);
            maradona = new Maradona("Diego Maradona", "Argentina", "Footballer", 83, 84, 83);
            messi = new Messi("Lionel Messi", "Barselona", "Footballer", 85, 86, 84);
            modric = new Modric("Luka Modric", "Real Madrid", "Footballer", 84, 81, 82);
            ronaldo = new Ronaldo("Cristiano Ronaldo", "Real Madrid", "Footballer", 83, 84, 81);
            ozil = new Ozil("Mesut Ozil", "Arsenal", "Footballer", 88, 84, 83);
            neymar = new Neymar("Neymar", "Barselona", "Footballer", 83, 85, 80);
            under = new Under("Cengiz Under", "Roma", "Footballer", 78, 82, 83);

            b_cards.Add(asik);
            b_cards.Add(cedi);
            b_cards.Add(dogus);
            b_cards.Add(ersan);
            b_cards.Add(erden);
            b_cards.Add(furkan);
            b_cards.Add(hido);
            b_cards.Add(memet);

            f_cards.Add(hazard);
            f_cards.Add(maradona);
            f_cards.Add(messi);
            f_cards.Add(modric);
            f_cards.Add(ronaldo);
            f_cards.Add(ozil);
            f_cards.Add(neymar);
            f_cards.Add(under);
        }

        public void DistributeCards()
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int ind = rnd.Next(0, 8 - i);
                human_player.Cards.Add(b_cards[ind]);
                b_cards.RemoveAt(ind);
            }
            for (int i = 0; i < 4; i++)
            {
                int ind = rnd.Next(0, 8 - i);
                human_player.Cards.Add(f_cards[ind]);
                f_cards.RemoveAt(ind);
            }
            for (int i = 3; i >= 0; i--)
            {
                computer_player.Cards.Add(b_cards[i]);
                b_cards.RemoveAt(i);
                computer_player.Cards.Add(f_cards[i]);
                f_cards.RemoveAt(i);
            }
        }

        private void athletePoint()
        {
            human_points.Text = human_player.Cards[selected_card].ShowAthletePoint();
            computer_points.Text = "?";
        }

        private void athleteName()
        {
            human_name_team.Text = human_player.Cards[selected_card].getAthleteName()
                + "\n" + human_player.Cards[selected_card].getAthleteTeam()
                    + "\n" + human_player.Cards[selected_card].getAthleteType();

            computer_name_team.Text = "???" + "\n" + "???" + "\n" + "???";
        }

        private void athletePicture()
        {
            player_1_picture.Image = human_player.Cards[selected_card].getAthleteImage();
            computerHidden();
        }
        private void computerHidden()
        {
            player_2_picture.Image = Image.FromFile("images\\hidden.JPG");
        }


        private void computerInfo(Athlete computer_card)
        {
            computer_points.Text = computer_card.ShowAthletePoint();

            computer_name_team.Text = computer_card.getAthleteName()
                + "\n" + computer_card.getAthleteTeam()
                + "\n" + computer_card.getAthleteType();

            player_2_picture.Image = computer_card.getAthleteImage();
        }

        private void playerScore(int h_score, int c_score)
        {
            score_1.Text = (human_player.showScore() + h_score).ToString();
            score_2.Text = (computer_player.showScore() + c_score).ToString();
        }

        private void backwards_button_Click(object sender, EventArgs e)
        {
            if (selected_card > 0)
            {
                selected_card--;
            }
            else
            {
                selected_card = 7 - counter;
            }
            athleteName();
            athletePoint();
            athletePicture();
            go.Enabled = true;
        }

        private void forward_button_Click(object sender, EventArgs e)
        {
            if (selected_card < 7 - counter)
            {
                selected_card++;
            }
            else
            {
                selected_card = 0;
            }
            athleteName();
            athletePoint();
            athletePicture();
            go.Enabled = true;
        }

        private void go_Click(object sender, EventArgs e)
        {
            Game();
            go.Enabled = false;
        }

        private void Game()
        {
            Athlete human_card = human_player.Cards[selected_card];

            string selected_type = human_player.Cards[selected_card].getAthleteType();

            Athlete computer_card = computer_player.SelectCard(selected_type, counter);

            computerInfo(computer_card);

            Random rnd = new Random();
            int spec = rnd.Next(0, 3);
            int h_value = human_card.SendAthleteValue(spec);
            int c_value = computer_card.SendAthleteValue(spec);

            selected_area_player_1.Text = h_value.ToString();
            selected_area_player_2.Text = c_value.ToString();

            if (h_value > c_value)
            {
                h_score += 10;
                playerScore(h_score, c_score);
                human_player.Cards.RemoveAt(selected_card);
                computer_player.Cards.Remove(computer_card);
                counter++;
                if (selected_card != 0)
                {
                    selected_card--;
                }
                else
                {
                    selected_card = 7 - counter;
                }
            }
            else if (h_value < c_value)
            {
                c_score += 10;
                playerScore(h_score, c_score);
                human_player.Cards.RemoveAt(selected_card);
                computer_player.Cards.Remove(computer_card);
                counter++;
                if (selected_card != 0)
                {
                    selected_card--;
                }
                else
                {
                    selected_card = 7 - counter;
                }
            }
            Gameover();

        }

        private void Gameover()
        {
            if (human_player.Cards.Count() == 0)
            {
                if (h_score > c_score)
                {
                    player_wins.Text = human_player.getPlayerName() + " Wins!!!";
                }
                else if (c_score > h_score)
                {
                    player_wins.Text = computer_player.getPlayerName() + " Wins!!!";
                }
                else
                {
                    player_wins.Text = "Draw";
                }

                player_wins.Visible = true;
                game_over_lbl.Visible = true;
                forward_button.Enabled = false;
                backwards_button.Enabled = false;
            }
        }

        private void player_wins_Click(object sender, EventArgs e)
        {

        }
    }
}
