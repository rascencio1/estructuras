namespace _22feb
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblLlenado = new System.Windows.Forms.Label();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "entrada";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(483, 72);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(326, 75);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 2;
            this.txtEntrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(326, 222);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(726, 176);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(0, 13);
            this.lblDireccion.TabIndex = 4;
            // 
            // lblLlenado
            // 
            this.lblLlenado.AutoSize = true;
            this.lblLlenado.Location = new System.Drawing.Point(114, 176);
            this.lblLlenado.Name = "lblLlenado";
            this.lblLlenado.Size = new System.Drawing.Size(0, 13);
            this.lblLlenado.TabIndex = 5;
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Location = new System.Drawing.Point(315, 365);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(0, 13);
            this.lblSensor1.TabIndex = 6;
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Location = new System.Drawing.Point(427, 365);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(0, 13);
            this.lblSensor2.TabIndex = 7;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(508, 222);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 8;
            this.btnFecha.Text = "Cambiar fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(767, 365);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 538);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.lblSensor2);
            this.Controls.Add(this.lblSensor1);
            this.Controls.Add(this.lblLlenado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblLlenado;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}

