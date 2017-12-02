using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Classes
{
    class Game
    {
        private int num;
        private string name;
        private string[] characters;
        private string[] possibleCharacters;

        private int numOfShotTypes;
        private string[] shotTypes;
        string[] possibleShotTypes = new string[4];

        public Game()
        {

        }

        public Game(int num, string name, int numOfShotTypes)
        {
            this.num = num;
            this.name = name;
            this.numOfShotTypes = numOfShotTypes;
            this.shotTypes = new string[numOfShotTypes];
            this.possibleCharacters = new string[5];
            this.setPossibleCharacters();
            this.setPossibleShotTypes();

            switch (this.num)
            {
                case 6:
                    this.characters = new string[2];
                    for (int i = 0; i < characters.Length; i++)
                    {
                        characters[i] = possibleCharacters[i];
                    }
                    this.setShotTypes(2);
                    break;
                case 7:
                    this.characters = new string[3];
                    for (int i = 0; i < characters.Length; i++)
                    {
                        characters[i] = possibleCharacters[i];
                    }
                    this.setShotTypes(2);
                    break;
                case 16:
                    this.characters = new string[4];
                    characters[0] = possibleCharacters[0];
                    characters[1] = possibleCharacters[1];
                    characters[2] = possibleCharacters[3];
                    characters[3] = possibleCharacters[4];
                    this.setShotTypes(4);
                    break;
                default:
                    break;
            }
        }

        public void setPossibleCharacters()
        {
            // Default
            possibleCharacters[0] = "Reimu";
            possibleCharacters[1] = "Marisa";

            // PCB
            possibleCharacters[2] = "Sakuya";

            // HSIFS
            possibleCharacters[3] = "Aya";
            possibleCharacters[4] = "Cirno";
        }

        public void setPossibleShotTypes()
        {
            possibleShotTypes[0] = "A";
            possibleShotTypes[1] = "B";
            possibleShotTypes[2] = "C";
            possibleShotTypes[3] = "D";
        }

        public void setShotTypes(int numOfShotTypes)
        {
            for (int i = 0; i < numOfShotTypes; i++)
            {
                shotTypes[i] = possibleShotTypes[i];
            }
        }

        public int getNum()
        {
            return num;
        }

        public string getName()
        {
            return name;
        }

        public string[] getCharacters()
        {
            return characters;
        }

        public string[] getShotTypes()
        {
            return shotTypes;
        }

        public Game getGame()
        {
            return this;
        }
    }
}
