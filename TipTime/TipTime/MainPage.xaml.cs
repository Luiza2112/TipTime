namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Percentage15Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 15;
        }

        private void Percentage30Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 30;
        }
        
        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {
            //Arredondar o valor para o menor número inteiro próximo do valor.

            double valorDaConta = Convert.ToDouble(ValueEntry.Text);
            double porcentagemDaGorjeta = TipPercentageSlider.Value / 100;
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            valorDaGorjeta = Math.Floor(valorDaGorjeta);
            double totalConta = valorDaGorjeta + valorDaConta;

            TotalLabel.Text = totalConta.ToString();
            TipLabel.Text = valorDaGorjeta.ToString();
        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {
            //Arredondar o valor para o maior número inteiro próximo do valor.

            double valorDaConta = Convert.ToDouble(ValueEntry.Text);
            double porcentagemDaGorjeta = TipPercentageSlider.Value / 100;
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            valorDaGorjeta = Math.Ceiling(valorDaGorjeta);
            double totalConta = valorDaGorjeta + valorDaConta;

            TotalLabel.Text = totalConta.ToString();
            TipLabel.Text = valorDaGorjeta.ToString();
        }

        private void OnTipPercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valorDoSlider = TipPercentageSlider.Value;
            TipPercentageLabel.Text = valorDoSlider.ToString() + "%";
        }
    }

}