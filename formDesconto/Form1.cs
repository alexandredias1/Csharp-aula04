namespace formDesconto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                value = value / 10;
                // Adiciona 500 ao valor se a primeira CheckBox estiver marcada
                if (checkBox1.Checked)
                {
                    value -= 50;
                }
                // Exibe o resultado no Label
                label3.Text = "Resultado: " + value.ToString();
            }
            else
            {
                // Exibe uma mensagem de erro se o valor não for um número válido
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}