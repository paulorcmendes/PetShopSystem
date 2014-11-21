namespace PetPamonha
{
    partial class telaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTelaPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTratamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListaDePets = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.menuTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTelaPrincipal
            // 
            this.menuTelaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.menuListaDePets});
            this.menuTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuTelaPrincipal.Name = "menuTelaPrincipal";
            this.menuTelaPrincipal.Size = new System.Drawing.Size(758, 24);
            this.menuTelaPrincipal.TabIndex = 0;
            this.menuTelaPrincipal.Text = "menuTelaPrincipal";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuPet,
            this.menuTratamento});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(152, 22);
            this.menuCliente.Text = "Cliente";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuPet
            // 
            this.menuPet.Name = "menuPet";
            this.menuPet.Size = new System.Drawing.Size(152, 22);
            this.menuPet.Text = "Pet";
            this.menuPet.Click += new System.EventHandler(this.menuPet_Click);
            // 
            // menuTratamento
            // 
            this.menuTratamento.Name = "menuTratamento";
            this.menuTratamento.Size = new System.Drawing.Size(152, 22);
            this.menuTratamento.Text = "Tratamento";
            this.menuTratamento.Click += new System.EventHandler(this.menuTratamento_Click);
            // 
            // menuListaDePets
            // 
            this.menuListaDePets.Name = "menuListaDePets";
            this.menuListaDePets.Size = new System.Drawing.Size(84, 20);
            this.menuListaDePets.Text = "Lista de Pets";
            this.menuListaDePets.Click += new System.EventHandler(this.menuListaDePets_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(73, 181);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(167, 91);
            this.btnCheckin.TabIndex = 1;
            this.btnCheckin.Text = "Check In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.Location = new System.Drawing.Point(481, 181);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(167, 91);
            this.btnAgendamento.TabIndex = 2;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.UseVisualStyleBackColor = true;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(758, 294);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.menuTelaPrincipal);
            this.MainMenuStrip = this.menuTelaPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaPrincipal";
            this.Text = "telaPrincipal";
            this.menuTelaPrincipal.ResumeLayout(false);
            this.menuTelaPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTelaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuPet;
        private System.Windows.Forms.ToolStripMenuItem menuListaDePets;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.ToolStripMenuItem menuTratamento;
    }
}