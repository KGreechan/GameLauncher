using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLauncher.Classes;

namespace GameLauncher
{
    public partial class Launcher : Form
    {
        Game th6;
        Game th7;
        Game th16;
        Random r;

        List<Game> chosenGames;
        public Launcher()
        {
            InitializeComponent();
        }


        private void Launcher_Load(object sender, EventArgs e)
        {
            th6 = new Game(6, "Touhou 6: Embodiment of Scarlet Devil", 2);
            th7 = new Game(7, "Touhou 7: Perfect Cherry Blossom", 2);
            th16 = new Game(16, "Touhou 16: Hidden Star in Four Seasons", 4);
            r = new Random();

            chosenGames = new List<Game>();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Launcher_Load(sender, e);
            if (check6.Checked)
                chosenGames.Add(th6);
            if (check7.Checked)
                chosenGames.Add(th7);
            if (check16.Checked)
                chosenGames.Add(th16);

            if (!check6.Checked && !check7.Checked && !check16.Checked)
            {
                lblError.Text = "You must select at least one game!";
            } else
            {
                Game chosenGame = new Game();
                string chosenChar = "";
                string chosenShot = "";

                // Randomize 3 times, to reduce amount of times same results are shown!
                // TODO : PREVENT THE SAME RESULTS SHOWING UP
                for (int i = 0; i < 3; i++)
                {
                    chosenGame = generateRandomGame(chosenGames);
                    chosenChar = generateRandomCharacter(chosenGame);
                    chosenShot = generateRandomShot(chosenGame);
                }
                

                lblGame.Text = chosenGame.getName();
                lblCharacter.Text = chosenChar;
                lblShotType.Text = chosenShot;
            }
        }

        private Game generateRandomGame(List<Game> chosenGames)
        {
            int randomGame = r.Next(chosenGames.Count);
            Game chosen = new Game();

            switch (randomGame)
            {
                case 0:
                    chosen = chosenGames[0].getGame();
                    break;
                case 1:
                    chosen = chosenGames[1].getGame();
                    break;
                case 2:
                    chosen = chosenGames[2].getGame();
                    break;
                default:
                    break;
            }
            return chosen;
        }

        private string generateRandomCharacter(Game chosen)
        {
            int randomChar = r.Next(chosen.getCharacters().Count);
            string chosenCharacter = chosen.getCharacters()[randomChar];

            return chosenCharacter;
        }

        private string generateRandomShot(Game chosen)
        {
            int randomShot = r.Next(chosen.getShotTypes().Count);
            string chosenShot = chosen.getShotTypes()[randomShot];
            
            if(chosen.getName() == "Touhou 16: Hidden Star in Four Seasons")
            {
                switch (chosenShot) 
                {
                    case "A":
                        chosenShot = "Spring";
                        break;
                    case "B":
                        chosenShot = "Summer";
                        break;
                    case "C":
                        chosenShot = "Autumn";
                        break;
                    case "D":
                        chosenShot = "Winter";
                        break;
                    default:
                        break;
                }
            }
            return chosenShot;
        }
    }
}
