namespace DiceRoller;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        buttonCalc.Clicked += OnRollButtonClicked;
    }

    private void OnRollButtonClicked(object sender, EventArgs e)
    {
        if (diceList.SelectedIndex >= 0)
        {
            int numberSides = int.Parse(diceList.SelectedItem.ToString());
            int result = RollDice(numberSides);

            diceResult.Text = result.ToString();
        }
    }

    private int RollDice(int numberSides)
    {
        Random random = new Random();
        return random.Next(1, numberSides + 1);
    }

}

