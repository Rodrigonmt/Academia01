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
            if (Globais.logado == true)//verifica se o usuário está logado e o nivel de acesso
            {
                if (Globais.nivel >= 2)
                {
                    //PROCEDIMENTOS DA JANELA AQUI
                }
                else
                {
                    MessageBox.Show("Usuário não possui liberação de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado!");
            }
        }

        private void nOVOUSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)//verifica se o usuário está logado e o nivel de acesso
            {
                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não possui liberação de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado!");
            }
        }

        private void gESTÃOUSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)//verifica se o usuário está logado e o nivel de acesso
            {
                if (Globais.nivel >= 1)
                {
                    //PROCEDIMENTOS DA JANELA AQUI
                }
                else
                {
                    MessageBox.Show("Usuário não possui liberação de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado!");
            }
        }

        private void nOVOALUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)//verifica se o usuário está logado e o nivel de acesso
            {
                if (Globais.nivel >= 0)
                {
                    //PROCEDIMENTOS DA JANELA AQUI
                }
                else
                {
                    MessageBox.Show("Usuário não possui liberação de acesso");
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado!");
            }
        }
    }
}
