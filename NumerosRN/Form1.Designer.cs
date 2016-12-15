namespace NumerosRN
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
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.clN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clYo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clYd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(637, 191);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(150, 54);
            this.btnAnalizar.TabIndex = 14;
            this.btnAnalizar.Text = "ANALIZAR";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txt7
            // 
            this.txt7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt7.ForeColor = System.Drawing.SystemColors.Window;
            this.txt7.Location = new System.Drawing.Point(31, 162);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 20);
            this.txt7.TabIndex = 17;
            this.txt7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt7_MouseDoubleClick);
            this.txt7.MouseCaptureChanged += new System.EventHandler(this.txt7_MouseCaptureChanged);
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt4.ForeColor = System.Drawing.SystemColors.Window;
            this.txt4.Location = new System.Drawing.Point(31, 101);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(88, 20);
            this.txt4.TabIndex = 16;
            this.txt4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt4_MouseDoubleClick);
            this.txt4.MouseCaptureChanged += new System.EventHandler(this.txt4_MouseCaptureChanged);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt1.ForeColor = System.Drawing.SystemColors.Window;
            this.txt1.Location = new System.Drawing.Point(31, 41);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 15;
            this.txt1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt1_MouseDoubleClick);
            this.txt1.MouseCaptureChanged += new System.EventHandler(this.txt1_MouseCaptureChanged);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt2.ForeColor = System.Drawing.SystemColors.Window;
            this.txt2.Location = new System.Drawing.Point(114, 58);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(17, 63);
            this.txt2.TabIndex = 18;
            this.txt2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt2_MouseDoubleClick);
            this.txt2.MouseCaptureChanged += new System.EventHandler(this.txt2_MouseCaptureChanged);
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt3.ForeColor = System.Drawing.SystemColors.Window;
            this.txt3.Location = new System.Drawing.Point(31, 58);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(17, 47);
            this.txt3.TabIndex = 19;
            this.txt3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt3_MouseDoubleClick);
            this.txt3.MouseCaptureChanged += new System.EventHandler(this.txt3_MouseCaptureChanged);
            // 
            // txt6
            // 
            this.txt6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt6.ForeColor = System.Drawing.SystemColors.Window;
            this.txt6.Location = new System.Drawing.Point(31, 119);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(17, 47);
            this.txt6.TabIndex = 21;
            this.txt6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt6_MouseDoubleClick);
            this.txt6.MouseCaptureChanged += new System.EventHandler(this.txt6_MouseCaptureChanged);
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt5.ForeColor = System.Drawing.SystemColors.Window;
            this.txt5.Location = new System.Drawing.Point(114, 119);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(17, 47);
            this.txt5.TabIndex = 20;
            this.txt5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt5_MouseDoubleClick);
            this.txt5.MouseCaptureChanged += new System.EventHandler(this.txt5_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "RECONOCIMIENTO NUMÉRICO CON REDES NEURONALES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.txt7);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt5);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt6);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Location = new System.Drawing.Point(38, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 206);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONAR PATRÓN";
            // 
            // lvN
            // 
            this.lvN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvN.Location = new System.Drawing.Point(6, 19);
            this.lvN.Name = "lvN";
            this.lvN.Size = new System.Drawing.Size(348, 176);
            this.lvN.TabIndex = 25;
            this.lvN.UseCompatibleStateImageBehavior = false;
            this.lvN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NEURONAS";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "VALOR Xi";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PESO Wi";
            this.columnHeader3.Width = 82;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvN);
            this.groupBox2.Location = new System.Drawing.Point(242, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 201);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA NEURONAS";
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clN,
            this.clPatron,
            this.clWb,
            this.clNet,
            this.clYo,
            this.clYd,
            this.clRd});
            this.dgDatos.Location = new System.Drawing.Point(38, 272);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(749, 197);
            this.dgDatos.TabIndex = 28;
            // 
            // clN
            // 
            this.clN.HeaderText = "Número";
            this.clN.Name = "clN";
            // 
            // clPatron
            // 
            this.clPatron.HeaderText = "Patrón";
            this.clPatron.Name = "clPatron";
            // 
            // clWb
            // 
            this.clWb.HeaderText = "Wb";
            this.clWb.Name = "clWb";
            // 
            // clNet
            // 
            this.clNet.HeaderText = "NET";
            this.clNet.Name = "clNet";
            // 
            // clYo
            // 
            this.clYo.HeaderText = "Yo";
            this.clYo.Name = "clYo";
            // 
            // clYd
            // 
            this.clYd.HeaderText = "Yd";
            this.clYd.Name = "clYd";
            // 
            // clRd
            // 
            this.clRd.HeaderText = "Regla Delta";
            this.clRd.Name = "clRd";
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(667, 125);
            this.txtFinal.Multiline = true;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 60);
            this.txtFinal.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "NÚMERO HALLADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvN;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPatron;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clYo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clYd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRd;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label2;
    }
}

