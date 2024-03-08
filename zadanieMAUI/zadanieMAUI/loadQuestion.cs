using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieMAUI
{
    internal class loadQuestion
    {
        public Dictionary<int, string> trivia = new Dictionary<int, string>();
        public Dictionary<int, string[]> questions = new Dictionary<int, string[]>();

        public string[] rightQuestions = { "Japan", "World Wide Web", "Leonardo da Vinci", "Web browsers", "2004", "Vin Diesel", "Madonna", "Three", "Cheetah", "Yellow" };
        public string[] images = { "starbucks.png", "www.jpg", "monalisa.jpg", "webrowser.jpg", "facebook.png", "groot.jpg", "materialgirl.jpg", "octopusl.jpg", "gato.jpg", "frog.jpg" };
        public List<int> randomized = new List<int>();

        //Oznaci ako sa nahodne budu odpovede generovat
        public void randomizeQuestions()
        {
            Random Random = new Random();
            int index = 0;

            while (true)
            {
                int randomNum = Random.Next(4);

                if (index == 4)
                    break;

                if (!randomized.Contains(randomNum))
                {
                    index++;
                    randomized.Add(randomNum);
                }
            }
        }
    }
}
