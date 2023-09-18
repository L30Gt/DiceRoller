namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        buttonCalc.Clicked += ButtonClicked;

        diceList.SelectedIndexChanged += PickerChanged;
    }

    public class Dice
    {
        public Dice (int numSides)
        {
            this.numSides = numSides;
        }
        private int numSides;

        public int RollDice()
        {
            Random random = new Random();
            return random.Next(1, numSides + 1);
        }
    }

    private void ButtonClicked(object sender, EventArgs e)
    {
        if (diceList.SelectedIndex >= 0)
        {
            int numSides = int.Parse(diceList.SelectedItem.ToString());

            /*  Criando uma instância da classe Dice e atribuindo-a à variável dice
                NomeDaClasse nomeDaVariavel = new NomeDaClasse(argumentos); */
            Dice dice = new Dice(numSides);

            int result = dice.RollDice();

            diceResult.Text = result.ToString();

            //diceImage.Source = ImageSource.FromFile($"dice_d{numSides}.png");
        }
    }

    private void PickerChanged(object sender, EventArgs e)
    {
        if (diceList.SelectedIndex >= 0)
        {
            int numSides = int.Parse(diceList.SelectedItem.ToString());

            diceImage.Source = ImageSource.FromFile($"dice_d{numSides}.png");
        }
    }
}


