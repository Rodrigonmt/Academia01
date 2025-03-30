namespace Academia01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pb_ledLogado = new PictureBox();
            label1 = new Label();
            lb_acesso = new Label();
            label3 = new Label();
            lb_nomeUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lb_nomeUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lb_acesso);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pb_ledLogado);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 35);
            panel1.TabIndex = 0;
            // 
            // pb_ledLogado
            // 
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            pb_ledLogado.Location = new Point(3, 3);
            pb_ledLogado.Name = "pb_ledLogado";
            pb_ledLogado.Size = new Size(30, 27);
            pb_ledLogado.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_ledLogado.TabIndex = 0;
            pb_ledLogado.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 11);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Acesso:";
            // 
            // lb_acesso
            // 
            lb_acesso.AutoSize = true;
            lb_acesso.Location = new Point(91, 11);
            lb_acesso.Name = "lb_acesso";
            lb_acesso.Size = new Size(13, 15);
            lb_acesso.TabIndex = 2;
            lb_acesso.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 11);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuário:";
            // 
            // lb_nomeUsuario
            // 
            lb_nomeUsuario.AutoSize = true;
            lb_nomeUsuario.Location = new Point(179, 11);
            lb_nomeUsuario.Name = "lb_nomeUsuario";
            lb_nomeUsuario.Size = new Size(22, 15);
            lb_nomeUsuario.TabIndex = 2;
            lb_nomeUsuario.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 373);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicativo Academia v1.0";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_nomeUsuario;
        private Label label3;
        private Label lb_acesso;
        private Label label1;
        public PictureBox pb_ledLogado;
    }
}
