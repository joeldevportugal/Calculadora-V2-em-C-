namespace Calculadora
{
    public partial class FrCalculadoraV2 : Form
    {

        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private Operacao operacaoSelecionada { get; set; }

        enum Operacao
        {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao,

        }


        public FrCalculadoraV2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bzero_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '0';
        }

        private void BUm_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '1';
        }

        private void BDois_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '2';
        }

        private void BTrês_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '3';
        }

        private void BQuatro_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '4';
        }

        private void BCinco_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '5';
        }

        private void Bseis_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '6';
        }

        private void Bsete_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '7';
        }

        private void Boito_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '8';
        }

        private void Bnove_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += '9';
        }

        private void Bponto_Click(object sender, EventArgs e)
        {

            if (!TxtResultado.Text.Contains(","))
                TxtResultado.Text += ",";
        }

        private void BDiv_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            LBLOperacao.Text = "/";
        }

        private void BMul_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            LBLOperacao.Text = "X";
        }

        private void BSub_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            LBLOperacao.Text = "-";
        }

        private void BSoma_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Soma;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            LBLOperacao.Text = "+";

        }

        private void Bigual_Click(object sender, EventArgs e)
        {
            switch (operacaoSelecionada)
            {
                case Operacao.Soma:
                    Resultado = Valor + Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(TxtResultado.Text);
                    break;
            }
            TxtResultado.Text = Convert.ToString(Resultado);
            LBLOperacao.Text = "=";
        }

        private void Bclean_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            LBLOperacao.Text = "";
        }

        private void BBackSpace_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text.Length > 0)
            {
                TxtResultado.Text = TxtResultado.Text.Remove(TxtResultado.Text.Length - 1);
            }

        }
    }
}
