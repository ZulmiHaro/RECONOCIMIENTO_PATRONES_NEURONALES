namespace ReconocimentodeNúmeros_RN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.cboNumeros = new System.Windows.Forms.ComboBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtR);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Controls.Add(this.cboNumeros);
            this.groupBox1.Controls.Add(this.txt7);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt6);
            this.groupBox1.Controls.Add(this.txt5);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PATRÓN A RECONOCER";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(413, 191);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(121, 20);
            this.txtR.TabIndex = 10;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(214, 191);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(121, 20);
            this.txtP.TabIndex = 9;
            // 
            // cboNumeros
            // 
            this.cboNumeros.FormattingEnabled = true;
            this.cboNumeros.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboNumeros.Location = new System.Drawing.Point(223, 48);
            this.cboNumeros.Name = "cboNumeros";
            this.cboNumeros.Size = new System.Drawing.Size(121, 21);
            this.cboNumeros.TabIndex = 8;
            // 
            // txt7
            // 
            this.txt7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt7.Enabled = false;
            this.txt7.Location = new System.Drawing.Point(48, 152);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 20);
            this.txt7.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt4.Enabled = false;
            this.txt4.Location = new System.Drawing.Point(48, 91);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(83, 20);
            this.txt4.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(48, 31);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(131, 48);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(17, 63);
            this.txt2.TabIndex = 3;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(48, 48);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(17, 47);
            this.txt3.TabIndex = 4;
            // 
            // txt6
            // 
            this.txt6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt6.Enabled = false;
            this.txt6.Location = new System.Drawing.Point(48, 109);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(17, 47);
            this.txt6.TabIndex = 6;
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt5.Enabled = false;
            this.txt5.Location = new System.Drawing.Point(131, 109);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(17, 47);
            this.txt5.TabIndex = 5;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(630, 205);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(121, 49);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgDatos
            // 
            this.dgDatos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgDatos.Enabled = false;
            this.dgDatos.Location = new System.Drawing.Point(34, 289);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(717, 204);
            this.dgDatos.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Orden";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Patrón";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 505);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "Form1";
            this.Text = "RED NEURONAL PARA RECONOCIMIENTO DE NÚMEROS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNumeros;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

