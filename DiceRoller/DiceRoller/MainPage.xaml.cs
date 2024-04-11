namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        Random rndNumber = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void RollerButton_Clicked(object sender, EventArgs e)
        {
            RandomNumber.Text = rndNumber.Next(1, (int)dicePicker.SelectedItem+1).ToString();
        }
    }

}
