namespace BoldorMihai
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Ai apasat o data";
            else
                CounterBtn.Text = $"Ai apasat de {count} ori";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
