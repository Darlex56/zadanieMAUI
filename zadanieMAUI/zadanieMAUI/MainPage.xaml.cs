namespace zadanieMAUI
{


    public partial class MainPage : ContentPage
    {
        FileReader fr = new FileReader();
        private int index = 0;
        public MainPage()
        {
            InitializeComponent();
            loadString();
        }

        public void loadString() { 
            fr.ReadFile();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            trivia.Text = fr.trivia[index][1];
            index++;   
        }
    }


}