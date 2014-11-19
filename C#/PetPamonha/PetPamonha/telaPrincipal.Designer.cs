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
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTelaPrincipal
            // 
            this.menuTelaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkinToolStripMenuItem,
            this.agendamentoToolStripMenuItem});
            this.menuTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuTelaPrincipal.Name = "menuTelaPrincipal";
            this.menuTelaPrincipal.Size = new System.Drawing.Size(758, 24);
            this.menuTelaPrincipal.TabIndex = 0;
            this.menuTelaPrincipal.Text = "menuTelaPrincipal";
            // 
            // checkinToolStripMenuItem
            // 
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.checkinToolStripMenuItem.Text = "Cadastro de Cliente";
            this.checkinToolStripMenuItem.Click += new System.EventHandler(this.checkinToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.agendamentoToolStripMenuItem.Text = "Cadastro de Animais";
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(758, 294);
            this.Controls.Add(this.menuTelaPrincipal);
            this.MainMenuStrip = this.menuTelaPrincipal;
            this.Name = "telaPrincipal";
            this.Text = "telaPrincipal";
            this.menuTelaPrincipal.ResumeLayout(false);
            this.menuTelaPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTelaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
    }
}