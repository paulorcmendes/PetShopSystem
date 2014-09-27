namespace PetPamonha
{
    partial class Checkin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkin));
            this.label1 = new System.Windows.Forms.Label();
            this.mktCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtPET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mktCPF
            // 
            this.mktCPF.Location = new System.Drawing.Point(61, 40);
            this.mktCPF.Mask = "000.000.000-00";
            this.mktCPF.Name = "mktCPF";
            this.mktCPF.Size = new System.Drawing.Size(89, 20);
            this.mktCPF.TabIndex = 4;
            this.mktCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtPET
            // 
            this.txtPET.Location = new System.Drawing.Point(83, 10);
            this.txtPET.Name = "txtPET";
            this.txtPET.Size = new System.Drawing.Size(205, 20);
            this.txtPET.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome PET: ";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRetirar.Location = new System.Drawing.Point(95, 88);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(124, 47);
            this.btnRetirar.TabIndex = 10;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(310, 159);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtPET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mktCPF);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checkin";
            this.Text = "Checkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mktCPF;
        private System.Windows.Forms.TextBox txtPET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetirar;
    }
}