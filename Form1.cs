namespace JogodaMemoria
{
    public partial class Form1 : Form
    {
        int movimentos, cliques, cartasAchadas, tagIndex;
        Image[] img = new Image[8];
        List<string> Lp = new List<string>();
        int[] tags = new int[2];

        public Form1()
        {
            InitializeComponent();
            Inicio();
        }
        private void Inicio()
        {
            cliques = 0;
            movimentos = 0;
            cartasAchadas = 0;

            foreach (PictureBox Verso in Controls.OfType<PictureBox>())
            {
                tagIndex = int.Parse(String.Format("{0}", Verso.Tag));
                img[tagIndex] = Verso.Image;
                Verso.Image = Properties.Resources.verso;
                Verso.Enabled = true;
            }
            Posicao();
        }
        private void Posicao()
        {
            Lp.Clear();
            foreach (PictureBox Verso in Controls.OfType<PictureBox>())
            {
                Random ps = new Random();
                int[] px = { 73, 209, 345, 481 };
                int[] py = { 103, 250, 397, 544 };


            Repete:
                var x = px[ps.Next(0, px.Length)];
                var y = px[ps.Next(0, py.Length)];

                Verso.Location = new Point(x, y);
                string verifica = x.ToString() + y.ToString();
                if (Lp.Contains(verifica))
                {
                    goto Repete;
                }
                else
                {
                    Verso.Location = new Point(x, y);
                    Lp.Add(verifica);
                }

            }
        }
        private void ClickImg_Click(object sender, EventArgs e)
        {
            bool parEncontrado = false;
            PictureBox cli = (PictureBox)sender;
            cliques++;
            tagIndex = int.Parse(String.Format("{0}", cli.Tag));
            cli.Image = img[tagIndex];
            cli.Refresh();
            if (cliques == 1)
            {
                tags[0] = int.Parse(String.Format("{0}", cli.Tag));
            }
            else if (cliques == 2)
            {
                movimentos++;
                label1.Text = "Movimentos: " + movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", cli.Tag));
                parEncontrado = ChecarPares();
                Desvirar(parEncontrado);
            }

        }
        private bool ChecarPares()
        {
            cliques = 0;
            if (tags[0] == tags[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Desvirar(bool check)
        {
            Thread.Sleep(500);
            foreach (PictureBox Verso in Controls.OfType<PictureBox>())
            {

                if (int.Parse(String.Format("{0}", Verso.Tag)) == tags[0] ||
                    int.Parse(String.Format("{0}", Verso.Tag)) == tags[1])
                {
                    if (check == true)
                    {
                        Verso.Enabled = false;
                        cartasAchadas++;
                    }
                    else
                    {
                        Verso.Image = Properties.Resources.verso;
                        Verso.Refresh();
                    }
                }
            }
            Final();
        }
        private void Final()
        {
            if (cartasAchadas == (img.Length * 2))
            {
                MessageBox.Show("Parabéns você achou todas as cartas com " + movimentos.ToString() + " movimentos");
                DialogResult msn = MessageBox.Show("Jogar de novo?", "Caixa Pergunta", MessageBoxButtons.YesNo);
                if (msn == DialogResult.Yes)
                {
             
                    Inicio();
                
                }
                else if (msn == DialogResult.No)
                {
                    MessageBox.Show("Até a próxima!");
                    Application.Exit();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

