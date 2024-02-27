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
        public Dictionary<int, string[]> trivia = new Dictionary<int, string[]>();
        
            

        public void ReadFile() {
            int index = 0;
            using (StreamReader sr = new StreamReader("C:\\Users\\Daniel\\Desktop\\GUI\\zadanieMAUI\\zadanieMAUI\\zadanieMAUI\\Resources\\Raw\\otazky.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string readText = sr.ReadLine();
                    string[] splitString = readText.Split('?');

                    trivia.Add(index, [splitString[1], splitString[0]]);
                    index++;
                }
            }

        }
    }
}
