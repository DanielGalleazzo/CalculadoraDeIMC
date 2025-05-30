namespace CalculadoraDeIMCWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string nome;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             nome = txtNome.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNome.Text ="Seu nome �: " + txtNome.Text;
            lblIdade.Text = "Sua idade �: " + txtIdade.Text;
            lblPeso.Text = "Seu peso �: " + txtPeso.Text + "kg";
            lblAltura.Text ="Sua altura � de:" + txtAltura.Text+"cm";
            double imc = peso / (altura * altura);
            if (imc < 0.0018) 
                lblIMC.Text = "Seu IMC est�: Abaixo do peso";
            else if (imc < 0.0025)
                    lblIMC.Text = "Seu IMC est�: Peso normal";
                else if (imc < 0.0030)
                    lblIMC.Text = "Seu IMC est�: Sobrepeso";
                else
                    lblIMC.Text = "Seu IMC est�: Obesidade";
            
        }
        int idade;
        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
             idade = int.Parse(txtIdade.Text);
        }

        double peso;
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
             peso = double.Parse(txtPeso.Text);
        }

        double altura;
        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
             altura = double.Parse(txtAltura.Text);
        }
    }
}
