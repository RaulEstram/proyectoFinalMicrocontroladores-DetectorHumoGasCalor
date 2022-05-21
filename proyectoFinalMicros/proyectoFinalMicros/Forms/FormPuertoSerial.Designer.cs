namespace proyectoFinalMicros.Forms
{
    partial class FormPuertoSerial
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
            this.labelPuertoSerialActual = new System.Windows.Forms.Label();
            this.labelPuertoSerial = new System.Windows.Forms.Label();
            this.comboBoxPuertosSeriales = new System.Windows.Forms.ComboBox();
            this.buttonActualizarPuertosSeriales = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPuertoSerialActual
            // 
            this.labelPuertoSerialActual.AutoSize = true;
            this.labelPuertoSerialActual.Font = new System.Drawing.Font("Georgia", 15F);
            this.labelPuertoSerialActual.ForeColor = System.Drawing.Color.Black;
            this.labelPuertoSerialActual.Location = new System.Drawing.Point(12, 9);
            this.labelPuertoSerialActual.Name = "labelPuertoSerialActual";
            this.labelPuertoSerialActual.Size = new System.Drawing.Size(194, 24);
            this.labelPuertoSerialActual.TabIndex = 0;
            this.labelPuertoSerialActual.Text = "Puerto Serial Actual:";
            // 
            // labelPuertoSerial
            // 
            this.labelPuertoSerial.AutoSize = true;
            this.labelPuertoSerial.Font = new System.Drawing.Font("Georgia", 15F);
            this.labelPuertoSerial.ForeColor = System.Drawing.Color.Black;
            this.labelPuertoSerial.Location = new System.Drawing.Point(212, 9);
            this.labelPuertoSerial.Name = "labelPuertoSerial";
            this.labelPuertoSerial.Size = new System.Drawing.Size(157, 24);
            this.labelPuertoSerial.TabIndex = 1;
            this.labelPuertoSerial.Text = "No Seleccionado";
            // 
            // comboBoxPuertosSeriales
            // 
            this.comboBoxPuertosSeriales.BackColor = System.Drawing.Color.White;
            this.comboBoxPuertosSeriales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPuertosSeriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPuertosSeriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPuertosSeriales.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPuertosSeriales.FormattingEnabled = true;
            this.comboBoxPuertosSeriales.Location = new System.Drawing.Point(16, 47);
            this.comboBoxPuertosSeriales.Name = "comboBoxPuertosSeriales";
            this.comboBoxPuertosSeriales.Size = new System.Drawing.Size(280, 26);
            this.comboBoxPuertosSeriales.TabIndex = 2;
            // 
            // buttonActualizarPuertosSeriales
            // 
            this.buttonActualizarPuertosSeriales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonActualizarPuertosSeriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.buttonActualizarPuertosSeriales.FlatAppearance.BorderSize = 0;
            this.buttonActualizarPuertosSeriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarPuertosSeriales.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarPuertosSeriales.ForeColor = System.Drawing.Color.White;
            this.buttonActualizarPuertosSeriales.Location = new System.Drawing.Point(12, 309);
            this.buttonActualizarPuertosSeriales.Name = "buttonActualizarPuertosSeriales";
            this.buttonActualizarPuertosSeriales.Size = new System.Drawing.Size(213, 40);
            this.buttonActualizarPuertosSeriales.TabIndex = 3;
            this.buttonActualizarPuertosSeriales.Text = "Actualizar Puertos Seriales";
            this.buttonActualizarPuertosSeriales.UseVisualStyleBackColor = false;
            this.buttonActualizarPuertosSeriales.Click += new System.EventHandler(this.buttonActualizarPuertosSeriales_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.buttonConectar.FlatAppearance.BorderSize = 0;
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConectar.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonConectar.ForeColor = System.Drawing.Color.White;
            this.buttonConectar.Location = new System.Drawing.Point(400, 309);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(122, 40);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.buttonDesconectar.FlatAppearance.BorderSize = 0;
            this.buttonDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesconectar.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonDesconectar.ForeColor = System.Drawing.Color.White;
            this.buttonDesconectar.Location = new System.Drawing.Point(272, 309);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(122, 40);
            this.buttonDesconectar.TabIndex = 5;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = false;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 25);
            this.textBox1.TabIndex = 6;
            // 
            // FormPuertoSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.buttonActualizarPuertosSeriales);
            this.Controls.Add(this.comboBoxPuertosSeriales);
            this.Controls.Add(this.labelPuertoSerial);
            this.Controls.Add(this.labelPuertoSerialActual);
            this.Name = "FormPuertoSerial";
            this.Text = "Configuracion Puerto Serial";
            this.Load += new System.EventHandler(this.FormPuertoSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPuertoSerialActual;
        private System.Windows.Forms.Label labelPuertoSerial;
        private System.Windows.Forms.ComboBox comboBoxPuertosSeriales;
        private System.Windows.Forms.Button buttonActualizarPuertosSeriales;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.TextBox textBox1;
    }
}