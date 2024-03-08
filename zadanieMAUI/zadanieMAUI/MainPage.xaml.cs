namespace zadanieMAUI
{


    public partial class MainPage : ContentPage
    {
        FileReader fr = new FileReader();
        loadQuestion lq = new loadQuestion();

        private int index = -1;
        private int questionAnsweredCorrectly = 0;

        public MainPage()
        {            
            InitializeComponent();
            loadString();
        }

        public void loadString() { 
            fr.ReadFile(lq.trivia);
            fr.alocateQuestions(lq.questions);
        }

        private void Next_Clicked(object sender, EventArgs e)
        {              
            //Skontroluj ak bol oznaceny nejaky radioButton ak odpoveda spravne zvysi sa pocet questionAnsweredCorrectly a zmeni sa na dalsiu otazku inak sa zmen na dalsiu otazku
            string selectedValue = checkRadioButton();
            if (selectedValue == null)
            {
                DisplayAlert("Error", "Please select an option", "OK");
            }
            else if (selectedValue == lq.rightQuestions[index])
            {
                questionAnsweredCorrectly++;
                nextQuestion();
            }
            else {
                nextQuestion();
            }  
        }
        
        private string checkRadioButton() {
            //Zisti hodnotu z radioButtons
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
            //Pridanie odpovedi k radioButtonom
            a.Content = lq.questions[index][lq.randomized[0]];
            b.Content = lq.questions[index][lq.randomized[1]];
            c.Content = lq.questions[index][lq.randomized[2]];
            d.Content = lq.questions[index][lq.randomized[3]];
            lq.randomized.Clear();
        }


        private void nextQuestion() {
            lq.randomizeQuestions();
            //Meni otazky a obrazky a ak boli pouzite vsetky otazky prejde na finalnu obrazovku
            if (lq.questions.Count - 1 != index) {               
                index++;
                trivia.Text = lq.trivia[index];
                img.Source = lq.images[index];
                changeRadioButton();
            }
            else 
                finalScreen();  
        }
        private void Begin_Clicked(object sender, EventArgs e)
        {
            //Schovanie/odkrytie elementov posunutie na otazky
            img.IsVisible = true;
            Begin.IsVisible = false;
            triviaForm.IsVisible = true;
            welcomeForm.IsVisible = false;

            nextQuestion();
        }
        private void finalScreen() 
        {
            //Schovanie/odkrytie elementov posunutie na finalnu obrazovku
            img.IsVisible= false;
            triviaForm.IsVisible= false;
            finalForm.IsVisible = true;

            finalLabel.Text = "You've answered " + questionAnsweredCorrectly + "/" + lq.questions.Count + " correctly";
        }

        private void exit_Clicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }
    }

    
}