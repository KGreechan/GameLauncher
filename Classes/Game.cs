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
        private List<string> characters;
        private List<string> possibleCharacters;

        private int numOfShotTypes;
        private List<string> shotTypes;
        private List<string> possibleShotTypes;

        public Game()
        {

        }

        public Game(int num, string name, int numOfShotTypes)
        {
            this.num = num;
            this.name = name;
            this.numOfShotTypes = numOfShotTypes;
            this.characters = new List<string>();
            this.possibleCharacters = new List<string>();
            this.shotTypes = new List<string>();
            this.possibleShotTypes = new List<string>();
            this.setPossibleCharacters();
            this.setPossibleShotTypes();

            switch (this.num)
            {
                case 6:
                    characters.Add(possibleCharacters[0]);
                    characters.Add(possibleCharacters[1]);
                    this.setShotTypes(2);
                    break;
                case 7:
                    characters.Add(possibleCharacters[0]);
                    characters.Add(possibleCharacters[1]);
                    characters.Add(possibleCharacters[2]);
                    this.setShotTypes(2);
                    break;
                case 16:
                    characters.Add(possibleCharacters[0]);
                    characters.Add(possibleCharacters[1]);
                    characters.Add(possibleCharacters[3]);
                    characters.Add(possibleCharacters[4]);
                    this.setShotTypes(4);
                    break;
                default:
                    break;
            }
        }

        public void setPossibleCharacters()
        {
            // Default
            possibleCharacters.Add("Reimu");
            possibleCharacters.Add("Marisa");
            // PCB
            possibleCharacters.Add("Sayuka");

            // HSIFS
            possibleCharacters.Add("Aya");
            possibleCharacters.Add("Cirno");
        }

        public void setPossibleShotTypes()
        {
            possibleShotTypes.Add("A");
            possibleShotTypes.Add("B");
            possibleShotTypes.Add("C");
            possibleShotTypes.Add("D");
        }

        public void setShotTypes(int numOfShotTypes)
        {
            for (int i = 0; i < numOfShotTypes; i++)
            {
                shotTypes.Add(possibleShotTypes[i]);
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

        public List<string> getCharacters()
        {
            return characters;
        }

        public List<string> getShotTypes()
        {
            return shotTypes;
        }

        public Game getGame()
        {
            return this;
        }
    }
}
