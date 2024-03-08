using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Storage;
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
        int index = 0;

        public void ReadFile(Dictionary<int, string> trivia) {
            int index = 0;
            //Nastavenie currentDirectory a  pridavanie otazok do Dictionary
            Directory.SetCurrentDirectory(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            using (StreamReader sr = new StreamReader(@"Resources\Texts\otazky.txt"))
            {
                while (!sr.EndOfStream)
                {
                    trivia.Add(index, sr.ReadLine());
                    index++;
                }
           }
        }
        public void alocateQuestions(Dictionary<int, string[]> questions)
        {
            //Pridavanie roznych odpovedi do Dictionary
            int index = 0;
            using (StreamReader sr = new StreamReader(@"Resources\Texts\answers.txt"))
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
