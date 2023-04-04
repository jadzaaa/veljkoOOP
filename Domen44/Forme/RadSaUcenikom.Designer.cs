namespace Forme
{
    partial class RadSaUcenikom
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
            this.dgvucenik = new System.Windows.Forms.DataGridView();
            this.txtjmbg = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnunos = new System.Windows.Forms.Button();
            this.cmbmesto = new System.Windows.Forms.ComboBox();
            this.cmbodeljenje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvucenik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvucenik
            // 
            this.dgvucenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvucenik.Location = new System.Drawing.Point(12, 12);
            this.dgvucenik.Name = "dgvucenik";
            this.dgvucenik.RowTemplate.Height = 24;
            this.dgvucenik.Size = new System.Drawing.Size(421, 242);
            this.dgvucenik.TabIndex = 0;
            // 
            // txtjmbg
            // 
            this.txtjmbg.Location = new System.Drawing.Point(589, 71);
            this.txtjmbg.Name = "txtjmbg";
            this.txtjmbg.Size = new System.Drawing.Size(100, 22);
            this.txtjmbg.TabIndex = 1;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(589, 129);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(100, 22);
            this.txtime.TabIndex = 2;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(589, 186);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(100, 22);
            this.txtprezime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jmbg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime";
            // 
            // btnunos
            // 
            this.btnunos.Location = new System.Drawing.Point(722, 101);
            this.btnunos.Name = "btnunos";
            this.btnunos.Size = new System.Drawing.Size(100, 79);
            this.btnunos.TabIndex = 7;
            this.btnunos.Text = "Unesi";
            this.btnunos.UseVisualStyleBackColor = true;
            this.btnunos.Click += new System.EventHandler(this.btnunos_Click);
            // 
            // cmbmesto
            // 
            this.cmbmesto.FormattingEnabled = true;
            this.cmbmesto.Location = new System.Drawing.Point(52, 294);
            this.cmbmesto.Name = "cmbmesto";
            this.cmbmesto.Size = new System.Drawing.Size(261, 24);
            this.cmbmesto.TabIndex = 8;
            // 
            // cmbodeljenje
            // 
            this.cmbodeljenje.FormattingEnabled = true;
            this.cmbodeljenje.Location = new System.Drawing.Point(52, 359);
            this.cmbodeljenje.Name = "cmbodeljenje";
            this.cmbodeljenje.Size = new System.Drawing.Size(261, 24);
            this.cmbodeljenje.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Odeljenje";
            // 
            // RadSaUcenikom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbodeljenje);
            this.Controls.Add(this.cmbmesto);
            this.Controls.Add(this.btnunos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.txtjmbg);
            this.Controls.Add(this.dgvucenik);
            this.Name = "RadSaUcenikom";
            this.Text = "RadSaUcenikom";
            this.Load += new System.EventHandler(this.RadSaUcenikom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvucenik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvucenik;
        private System.Windows.Forms.TextBox txtjmbg;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnunos;
        private System.Windows.Forms.ComboBox cmbmesto;
        private System.Windows.Forms.ComboBox cmbodeljenje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}