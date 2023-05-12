namespace PrjEscola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, faltas, media;

            faltas = int.Parse(textBox4.Text);
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            n3 = int.Parse(textBox3.Text);

            if (faltas > 12)
            {
                label6.Text = "Aluno está Reprovado por faltas!";
            }
            else
            {
                media = 3/(n1 + n2 + n3);

                   if (media <=5)
                    {
                    label6.Text = "Está Aprovado!";
                    }

                   else if (media >= 4 && media <= 5.5)
                    {
                    label6.Text = "Está no conselho de classe!";
                    }

                   else 
                    {
                    label6.Text = "Está Reprovado!";
                    }


            }
        }
    }
}