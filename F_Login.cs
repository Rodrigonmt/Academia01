﻿using System;
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
        DataTable dt=new DataTable();
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
            string username = tb_username.Text;
            string senha = tb_senha.Text;
            if (username==""||senha=="")
            {
                MessageBox.Show("Usuário e/ou senha inválido!");
                tb_username.Focus();
                return;
            }
            string sql = "select *from tb_usuarios where T_USERNAME='"+username+"' and T_SENHAUSUARIO='"+senha+"'";
            dt=Banco.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                Globais.nivel = int.Parse(dt.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha não encontrado!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
