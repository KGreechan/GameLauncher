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


        /*
         * This next section is for the launcher portion of the program
         */

        public string startURL = "E:\\Storage\\Games\\Touhou\\Official Games\\";
        public string startURL2 = "E:\\Storage\\Games\\Touhou\\Fan Games\\";
        private void btn6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 6 - Embodiment of Scarlet Devil\\th6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 7 - Perfect Cherry Blossom\\th7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 8 - Imperishable Night\\th8");
        }

        private void btn95_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 9.5 - Shoot the Bullet\\th095");
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 10 - Mountain of Faith\\th10");
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 11 - Subterranean Animism\\th11");
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 12 - Undefined Fantastic Object\\th12");
        }

        private void btn125_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 12.5 - Double Spoiler\\th125");
        }

        private void btn128_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 12.8 - Fairy Wars\\th128");
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 13 - Ten Desires\\th13");
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 14 - Double-Dealing Character\\th14");
        }

        private void btn143_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 14.3 - Impossible Spell Card\\th143");
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL + "Touhou 15 - Legacy of Lunatic Kingdom\\th15");
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\Steam\\steamapps\\common\\th16\\th16");
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL2 + "IT0000199161p\\IT0000199161\\rpg");
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(startURL2 + "东方夏夜祭\\东方夏夜祭 ～ Shining Shooting Star\\thpss");
        }
    }
}
