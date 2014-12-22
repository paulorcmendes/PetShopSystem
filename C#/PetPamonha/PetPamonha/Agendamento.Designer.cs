namespace PetPamonha
{
    partial class Agendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTratamento = new System.Windows.Forms.ComboBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtRGA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raça: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome PET: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(136, 104);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(237, 20);
            this.dtpData.TabIndex = 2;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgendar.Location = new System.Drawing.Point(146, 191);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(112, 44);
            this.btnAgendar.TabIndex = 4;
            this.btnAgendar.Text = "Checkin";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // cmbNome
            // 
            this.cmbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(136, 15);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(240, 21);
            this.cmbNome.TabIndex = 1;
            this.cmbNome.SelectedIndexChanged += new System.EventHandler(this.cmbNome_SelectedIndexChanged);
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(58, 50);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(0, 13);
            this.lblRaca.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data de Nascimento:";
            // 
            // lblRga
            // 
            this.lblRga.AutoSize = true;
            this.lblRga.Location = new System.Drawing.Point(56, 78);
            this.lblRga.Name = "lblRga";
            this.lblRga.Size = new System.Drawing.Size(0, 13);
            this.lblRga.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tratamento:";
            // 
            // cmbTratamento
            // 
            this.cmbTratamento.FormattingEnabled = true;
            this.cmbTratamento.Location = new System.Drawing.Point(136, 142);
            this.cmbTratamento.Name = "cmbTratamento";
            this.cmbTratamento.Size = new System.Drawing.Size(240, 21);
            this.cmbTratamento.TabIndex = 3;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(136, 47);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.ReadOnly = true;
            this.txtRaca.Size = new System.Drawing.Size(100, 20);
            this.txtRaca.TabIndex = 20;
            // 
            // txtRGA
            // 
            this.txtRGA.Location = new System.Drawing.Point(136, 73);
            this.txtRGA.Name = "txtRGA";
            this.txtRGA.ReadOnly = true;
            this.txtRGA.Size = new System.Drawing.Size(100, 20);
            this.txtRGA.TabIndex = 21;
            // 
            // Agendamento
            // 
            this.AcceptButton = this.btnAgendar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(409, 247);
            this.Controls.Add(this.txtRGA);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.cmbTratamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Checkin";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTratamento;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtRGA;
    }
}