namespace PetPamonha
{
    partial class ListadePets
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lblPetsTratamento = new System.Windows.Forms.Label();
            this.listAnimaisTratamento = new System.Windows.Forms.ListView();
            this.colRGA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomePet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTratamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPetsTratados = new System.Windows.Forms.Label();
            this.txtRGAterminados = new System.Windows.Forms.TextBox();
            this.btnTratado = new System.Windows.Forms.Button();
            this.lblAnimaisTratados = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colRGAtratados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomeTratados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonoTratados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblPetsTratamento
            // 
            this.lblPetsTratamento.AutoSize = true;
            this.lblPetsTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetsTratamento.Location = new System.Drawing.Point(78, 9);
            this.lblPetsTratamento.Name = "lblPetsTratamento";
            this.lblPetsTratamento.Size = new System.Drawing.Size(211, 17);
            this.lblPetsTratamento.TabIndex = 0;
            this.lblPetsTratamento.Text = "Lista de Animais em Tratamento";
            // 
            // listAnimaisTratamento
            // 
            this.listAnimaisTratamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRGA,
            this.colNomePet,
            this.colTratamento,
            this.colDono});
            this.listAnimaisTratamento.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listAnimaisTratamento.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listAnimaisTratamento.Location = new System.Drawing.Point(2, 29);
            this.listAnimaisTratamento.Name = "listAnimaisTratamento";
            this.listAnimaisTratamento.Size = new System.Drawing.Size(362, 302);
            this.listAnimaisTratamento.TabIndex = 1;
            this.listAnimaisTratamento.UseCompatibleStateImageBehavior = false;
            this.listAnimaisTratamento.View = System.Windows.Forms.View.Details;
            this.listAnimaisTratamento.SelectedIndexChanged += new System.EventHandler(this.listAnimaisTratamento_SelectedIndexChanged);
            // 
            // colRGA
            // 
            this.colRGA.Text = "RGA";
            // 
            // colNomePet
            // 
            this.colNomePet.Text = "Nome";
            // 
            // colTratamento
            // 
            this.colTratamento.Text = "Tipo de Tratamento";
            this.colTratamento.Width = 114;
            // 
            // colDono
            // 
            this.colDono.Text = "Dono do Pet";
            this.colDono.Width = 126;
            // 
            // lblPetsTratados
            // 
            this.lblPetsTratados.AutoSize = true;
            this.lblPetsTratados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetsTratados.Location = new System.Drawing.Point(391, 43);
            this.lblPetsTratados.Name = "lblPetsTratados";
            this.lblPetsTratados.Size = new System.Drawing.Size(118, 17);
            this.lblPetsTratados.TabIndex = 2;
            this.lblPetsTratados.Text = "Animais Tratados";
            // 
            // txtRGAterminados
            // 
            this.txtRGAterminados.Location = new System.Drawing.Point(394, 63);
            this.txtRGAterminados.Name = "txtRGAterminados";
            this.txtRGAterminados.Size = new System.Drawing.Size(115, 20);
            this.txtRGAterminados.TabIndex = 3;
            this.txtRGAterminados.Tag = "Coloque o RGA do Pet onde o tratamento acabou de ser concluído";
            // 
            // btnTratado
            // 
            this.btnTratado.Location = new System.Drawing.Point(408, 100);
            this.btnTratado.Name = "btnTratado";
            this.btnTratado.Size = new System.Drawing.Size(88, 52);
            this.btnTratado.TabIndex = 4;
            this.btnTratado.Text = "Tratado!!";
            this.btnTratado.UseVisualStyleBackColor = true;
            this.btnTratado.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAnimaisTratados
            // 
            this.lblAnimaisTratados.AutoSize = true;
            this.lblAnimaisTratados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimaisTratados.Location = new System.Drawing.Point(598, 9);
            this.lblAnimaisTratados.Name = "lblAnimaisTratados";
            this.lblAnimaisTratados.Size = new System.Drawing.Size(172, 17);
            this.lblAnimaisTratados.TabIndex = 5;
            this.lblAnimaisTratados.Text = "Lista de Animais Tratados";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRGAtratados,
            this.colNomeTratados,
            this.colDonoTratados});
            this.listView1.GridLines = true;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.Location = new System.Drawing.Point(515, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(323, 302);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colRGAtratados
            // 
            this.colRGAtratados.Text = "RGA";
            // 
            // colNomeTratados
            // 
            this.colNomeTratados.Text = "Nome";
            this.colNomeTratados.Width = 106;
            // 
            // colDonoTratados
            // 
            this.colDonoTratados.Text = "Dono";
            this.colDonoTratados.Width = 153;
            // 
            // ListadePets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(838, 343);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblAnimaisTratados);
            this.Controls.Add(this.btnTratado);
            this.Controls.Add(this.txtRGAterminados);
            this.Controls.Add(this.lblPetsTratados);
            this.Controls.Add(this.listAnimaisTratamento);
            this.Controls.Add(this.lblPetsTratamento);
            this.Name = "ListadePets";
            this.Text = "Lista de Pets na Loja";
            this.Load += new System.EventHandler(this.ListadePets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPetsTratamento;
        private System.Windows.Forms.ListView listAnimaisTratamento;
        private System.Windows.Forms.ColumnHeader colRGA;
        private System.Windows.Forms.ColumnHeader colNomePet;
        private System.Windows.Forms.ColumnHeader colTratamento;
        private System.Windows.Forms.ColumnHeader colDono;
        private System.Windows.Forms.Label lblPetsTratados;
        private System.Windows.Forms.TextBox txtRGAterminados;
        private System.Windows.Forms.Button btnTratado;
        private System.Windows.Forms.Label lblAnimaisTratados;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colRGAtratados;
        private System.Windows.Forms.ColumnHeader colNomeTratados;
        private System.Windows.Forms.ColumnHeader colDonoTratados;
    }
}