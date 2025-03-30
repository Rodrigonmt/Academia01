namespace Academia01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void lOGONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void lOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bANCODADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)//verifica se o usu�rio est� logado e o nivel de acesso
            {
                if (Globais.nivel >= 2)
                {
                    //PROCEDIMENTOS DA JANELA AQUI
                }
                else
                {
                    MessageBox.Show("Usu�rio n�o possui libera��o de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usu�rio logado!");
            }
        }

        private void nOVOUSU�RIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)//verifica se o usu�rio est� logado e o nivel de acesso
            {
                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usu�rio n�o possui libera��o de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usu�rio logado!");
            }
        }

        private void gEST�OUSU�RIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)//verifica se o usu�rio est� logado e o nivel de acesso
            {
                if (Globais.nivel >= 1)
                {
                    //PROCEDIMENTOS DA JANELA AQUI
                }
                else
                {
                    MessageBox.Show("Usu�rio n�o possui libera��o de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usu�rio logado!");
            }
        }

        private void nOVOALUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)//verifica se o usu�rio est� logado e o nivel de acesso
            {
                if (Globais.nivel >= 0)
                {
                    //PROCEDIMENTOS DA JANELA AQUI
                }
                else
                {
                    MessageBox.Show("Usu�rio n�o possui libera��o de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usu�rio logado!");
            }
        }
    }
}
