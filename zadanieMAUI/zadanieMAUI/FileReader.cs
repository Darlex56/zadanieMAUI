using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace zadanieMAUI
{

    internal class FileReader
    {
        public Dictionary<int, string> trivia = new Dictionary<int, string>();
        public Dictionary<int, string[]> questions = new Dictionary<int, string[]>();
        public string[] rightQuestions = { "Japan", "World Wide Web", "Leonardo da Vinci", "Web browsers", "2004", "Vin Diesel", "Madonna", "Three", "Cheetah", "Yellow" };
        public string[] images = { "starbucks.png", "dotnet_bot.png", "monalisa.jpg", "webrowser.jpg", "facebook.png", "groot.jpg", "materialgirl.jpg", "octopusl.jpg", "gato.jpg", "frog.jpg" };
        int index = 0;

        public void ReadFile() {
            int index = 0;
            using (StreamReader sr = new StreamReader("C:\\Users\\Daniel\\Desktop\\GUI\\zadanieMAUI\\zadanieMAUI\\zadanieMAUI\\Resources\\Raw\\otazky.txt"))
            {
                while (!sr.EndOfStream)
                {            
                    trivia.Add(index, sr.ReadLine());
                    index++;
                }
           }
        }
        public void alocateQuestions()
        {
            int index = 0;
            using (StreamReader sr = new StreamReader("C:\\Users\\Daniel\\Desktop\\GUI\\zadanieMAUI\\zadanieMAUI\\zadanieMAUI\\Resources\\Raw\\answers.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string readText = sr.ReadLine();
                    string[] splitString = readText.Split(',');

                    questions.Add(index, splitString);
                    index++;
                }
            }
        }
    }
}
