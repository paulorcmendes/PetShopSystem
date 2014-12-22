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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.menuTelaPrincipal = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTratamento = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btCheckin = new System.Windows.Forms.Button();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTelaPrincipal
            // 
            resources.ApplyResources(this.menuTelaPrincipal, "menuTelaPrincipal");
            this.menuTelaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuTelaPrincipal.Name = "menuTelaPrincipal";
            // 
            // programaToolStripMenuItem
            // 
            resources.ApplyResources(this.programaToolStripMenuItem, "programaToolStripMenuItem");
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkinToolStripMenuItem,
            this.finalizadosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            // 
            // checkinToolStripMenuItem
            // 
            resources.ApplyResources(this.checkinToolStripMenuItem, "checkinToolStripMenuItem");
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Click += new System.EventHandler(this.checkinToolStripMenuItem_Click);
            // 
            // finalizadosToolStripMenuItem
            // 
            resources.ApplyResources(this.finalizadosToolStripMenuItem, "finalizadosToolStripMenuItem");
            this.finalizadosToolStripMenuItem.Name = "finalizadosToolStripMenuItem";
            this.finalizadosToolStripMenuItem.Click += new System.EventHandler(this.finalizadosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            resources.ApplyResources(this.cadastroToolStripMenuItem, "cadastroToolStripMenuItem");
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuPet,
            this.menuTratamento});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            // 
            // menuCliente
            // 
            resources.ApplyResources(this.menuCliente, "menuCliente");
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // menuPet
            // 
            resources.ApplyResources(this.menuPet, "menuPet");
            this.menuPet.Name = "menuPet";
            this.menuPet.Click += new System.EventHandler(this.menuPet_Click);
            // 
            // menuTratamento
            // 
            resources.ApplyResources(this.menuTratamento, "menuTratamento");
            this.menuTratamento.Name = "menuTratamento";
            this.menuTratamento.Click += new System.EventHandler(this.menuTratamento_Click);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // btFinalizar
            // 
            resources.ApplyResources(this.btFinalizar, "btFinalizar");
            this.btFinalizar.BackColor = System.Drawing.Color.White;
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btCheckin
            // 
            resources.ApplyResources(this.btCheckin, "btCheckin");
            this.btCheckin.BackColor = System.Drawing.Color.White;
            this.btCheckin.Name = "btCheckin";
            this.btCheckin.UseVisualStyleBackColor = false;
            this.btCheckin.Click += new System.EventHandler(this.btCheckin_Click);
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // telaPrincipal
            // 
            this.AcceptButton = this.btFinalizar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btCheckin);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuTelaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuTelaPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaPrincipal";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
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
        private System.Windows.Forms.ToolStripMenuItem menuTratamento;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btCheckin;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}