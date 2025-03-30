using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia01
{
    public partial class F_Login : Form
    {
        Form1 form1;
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
