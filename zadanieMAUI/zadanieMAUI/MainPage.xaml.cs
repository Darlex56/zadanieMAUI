namespace zadanieMAUI
{


    public partial class MainPage : ContentPage
    {
        FileReader fr = new FileReader();

        private int index = -1;
        private int questionAnsweredCorrectly = 0;
        public MainPage()
        {
            InitializeComponent();
            loadString();
        }

        public void loadString() { 
            fr.ReadFile();
            fr.alocateQuestions();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {              
            string selectedValue = checkRadioButton();
           
            if (selectedValue == fr.rightQuestions[index])
            {
                questionAnsweredCorrectly++;
            }
            nextQuestion();
        }
        
        private string checkRadioButton() {
            if (a.IsChecked)
                return a.Content.ToString();
            if (b.IsChecked)
                return b.Content.ToString();
            if (c.IsChecked)
                return c.Content.ToString();
            if (d.IsChecked)
                return d.Content.ToString();
            return null;
        }
        private void changeRadioButton()
        {
            a.Content = fr.questions[index][3];
            b.Content = fr.questions[index][1];
            c.Content = fr.questions[index][0];
            d.Content = fr.questions[index][2];
        }

        private void nextQuestion() {
            if(fr.questions.Count - 1 != index) {               
                index++;
                trivia.Text = fr.trivia[index];
                img.Source = fr.images[index];
                changeRadioButton();
            }
            else 
                finalScreen();
            
        }
        private void Begin_Clicked(object sender, EventArgs e)
        {
            img.IsVisible = true;
            Begin.IsVisible = false;
            triviaForm.IsVisible = true;
            welcomeForm.IsVisible = false;

            nextQuestion();
        }
        private void finalScreen() 
        {
            img.IsVisible= false;
            triviaForm.IsVisible= false;
            finalForm.IsVisible = true;

            finalLabel.Text = "You've answered " + questionAnsweredCorrectly + "/" + fr.questions.Count + " correctly";
        }

        private void exit_Clicked(object sender, EventArgs e)
        {
            return;
        }
    }


}