namespace proyectoFinalMicros.Forms
{
    partial class FormModoAutomatico
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLBuzzer = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxBuzzer = new System.Windows.Forms.PictureBox();
            this.labelBuzzer = new System.Windows.Forms.Label();
            this.tableTemperatura = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGas = new System.Windows.Forms.Label();
            this.pictureBoxGas = new System.Windows.Forms.PictureBox();
            this.tableLed = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelActuadorLed = new System.Windows.Forms.Label();
            this.pictureBoxLed = new System.Windows.Forms.PictureBox();
            this.labelSensores = new System.Windows.Forms.Label();
            this.labelActuadores = new System.Windows.Forms.Label();
            this.tableGas = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLBuzzer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuzzer)).BeginInit();
            this.tableTemperatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGas)).BeginInit();
            this.tableLed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed)).BeginInit();
            this.tableGas.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLBuzzer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableTemperatura, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSensores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelActuadores, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableGas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLBuzzer
            // 
            this.tableLBuzzer.ColumnCount = 1;
            this.tableLBuzzer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLBuzzer.Controls.Add(this.label4, 0, 0);
            this.tableLBuzzer.Controls.Add(this.pictureBoxBuzzer, 0, 1);
            this.tableLBuzzer.Controls.Add(this.labelBuzzer, 0, 2);
            this.tableLBuzzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLBuzzer.Location = new System.Drawing.Point(270, 203);
            this.tableLBuzzer.Name = "tableLBuzzer";
            this.tableLBuzzer.RowCount = 3;
            this.tableLBuzzer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLBuzzer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLBuzzer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLBuzzer.Size = new System.Drawing.Size(261, 155);
            this.tableLBuzzer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Buzzer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBuzzer
            // 
            this.pictureBoxBuzzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBuzzer.Image = global::proyectoFinalMicros.Properties.Resources.buzzerDesactivado;
            this.pictureBoxBuzzer.Location = new System.Drawing.Point(3, 33);
            this.pictureBoxBuzzer.Name = "pictureBoxBuzzer";
            this.pictureBoxBuzzer.Size = new System.Drawing.Size(255, 89);
            this.pictureBoxBuzzer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBuzzer.TabIndex = 1;
            this.pictureBoxBuzzer.TabStop = false;
            // 
            // labelBuzzer
            // 
            this.labelBuzzer.AutoSize = true;
            this.labelBuzzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBuzzer.Font = new System.Drawing.Font("Georgia", 12F);
            this.labelBuzzer.ForeColor = System.Drawing.Color.Black;
            this.labelBuzzer.Location = new System.Drawing.Point(3, 125);
            this.labelBuzzer.Name = "labelBuzzer";
            this.labelBuzzer.Size = new System.Drawing.Size(255, 30);
            this.labelBuzzer.TabIndex = 2;
            this.labelBuzzer.Text = "Desactivado";
            this.labelBuzzer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableTemperatura
            // 
            this.tableTemperatura.ColumnCount = 1;
            this.tableTemperatura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTemperatura.Controls.Add(this.label3, 0, 0);
            this.tableTemperatura.Controls.Add(this.labelGas, 0, 2);
            this.tableTemperatura.Controls.Add(this.pictureBoxGas, 0, 1);
            this.tableTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTemperatura.Location = new System.Drawing.Point(3, 203);
            this.tableTemperatura.Name = "tableTemperatura";
            this.tableTemperatura.RowCount = 3;
            this.tableTemperatura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableTemperatura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTemperatura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableTemperatura.Size = new System.Drawing.Size(261, 155);
            this.tableTemperatura.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Humo / Gas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGas
            // 
            this.labelGas.AutoSize = true;
            this.labelGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGas.Font = new System.Drawing.Font("Georgia", 12F);
            this.labelGas.ForeColor = System.Drawing.Color.Black;
            this.labelGas.Location = new System.Drawing.Point(3, 125);
            this.labelGas.Name = "labelGas";
            this.labelGas.Size = new System.Drawing.Size(255, 30);
            this.labelGas.TabIndex = 1;
            this.labelGas.Text = "ppm";
            this.labelGas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGas
            // 
            this.pictureBoxGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGas.Image = global::proyectoFinalMicros.Properties.Resources.smoke;
            this.pictureBoxGas.Location = new System.Drawing.Point(3, 33);
            this.pictureBoxGas.Name = "pictureBoxGas";
            this.pictureBoxGas.Size = new System.Drawing.Size(255, 89);
            this.pictureBoxGas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGas.TabIndex = 2;
            this.pictureBoxGas.TabStop = false;
            // 
            // tableLed
            // 
            this.tableLed.ColumnCount = 1;
            this.tableLed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLed.Controls.Add(this.label2, 0, 0);
            this.tableLed.Controls.Add(this.labelActuadorLed, 0, 2);
            this.tableLed.Controls.Add(this.pictureBoxLed, 0, 1);
            this.tableLed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLed.Location = new System.Drawing.Point(270, 43);
            this.tableLed.Name = "tableLed";
            this.tableLed.RowCount = 3;
            this.tableLed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLed.Size = new System.Drawing.Size(261, 154);
            this.tableLed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Led";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActuadorLed
            // 
            this.labelActuadorLed.AutoSize = true;
            this.labelActuadorLed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelActuadorLed.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActuadorLed.ForeColor = System.Drawing.Color.Black;
            this.labelActuadorLed.Location = new System.Drawing.Point(3, 124);
            this.labelActuadorLed.Name = "labelActuadorLed";
            this.labelActuadorLed.Size = new System.Drawing.Size(255, 30);
            this.labelActuadorLed.TabIndex = 1;
            this.labelActuadorLed.Text = "Todo Bien";
            this.labelActuadorLed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLed
            // 
            this.pictureBoxLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLed.Image = global::proyectoFinalMicros.Properties.Resources.LUZ_VERDE;
            this.pictureBoxLed.Location = new System.Drawing.Point(3, 33);
            this.pictureBoxLed.Name = "pictureBoxLed";
            this.pictureBoxLed.Size = new System.Drawing.Size(255, 88);
            this.pictureBoxLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLed.TabIndex = 2;
            this.pictureBoxLed.TabStop = false;
            // 
            // labelSensores
            // 
            this.labelSensores.AutoSize = true;
            this.labelSensores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSensores.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensores.ForeColor = System.Drawing.Color.Black;
            this.labelSensores.Location = new System.Drawing.Point(3, 0);
            this.labelSensores.Name = "labelSensores";
            this.labelSensores.Size = new System.Drawing.Size(261, 40);
            this.labelSensores.TabIndex = 0;
            this.labelSensores.Text = "Sensores";
            this.labelSensores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActuadores
            // 
            this.labelActuadores.AutoSize = true;
            this.labelActuadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelActuadores.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActuadores.ForeColor = System.Drawing.Color.Black;
            this.labelActuadores.Location = new System.Drawing.Point(270, 0);
            this.labelActuadores.Name = "labelActuadores";
            this.labelActuadores.Size = new System.Drawing.Size(261, 40);
            this.labelActuadores.TabIndex = 1;
            this.labelActuadores.Text = "Actuadores";
            this.labelActuadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableGas
            // 
            this.tableGas.ColumnCount = 1;
            this.tableGas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableGas.Controls.Add(this.label1, 0, 0);
            this.tableGas.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGas.Location = new System.Drawing.Point(3, 43);
            this.tableGas.Name = "tableGas";
            this.tableGas.RowCount = 2;
            this.tableGas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableGas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableGas.Size = new System.Drawing.Size(261, 154);
            this.tableGas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTemperatura, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(255, 118);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::proyectoFinalMicros.Properties.Resources.temperatura;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTemperatura.Font = new System.Drawing.Font("Georgia", 15F);
            this.labelTemperatura.ForeColor = System.Drawing.Color.Black;
            this.labelTemperatura.Location = new System.Drawing.Point(130, 0);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(122, 118);
            this.labelTemperatura.TabIndex = 1;
            this.labelTemperatura.Text = "20 °C";
            this.labelTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormModoAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormModoAutomatico";
            this.Text = "Modo Automatico";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLBuzzer.ResumeLayout(false);
            this.tableLBuzzer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuzzer)).EndInit();
            this.tableTemperatura.ResumeLayout(false);
            this.tableTemperatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGas)).EndInit();
            this.tableLed.ResumeLayout(false);
            this.tableLed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed)).EndInit();
            this.tableGas.ResumeLayout(false);
            this.tableGas.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSensores;
        private System.Windows.Forms.Label labelActuadores;
        private System.Windows.Forms.TableLayoutPanel tableLBuzzer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableGas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelActuadorLed;
        private System.Windows.Forms.PictureBox pictureBoxLed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.PictureBox pictureBoxBuzzer;
        private System.Windows.Forms.Label labelBuzzer;
        private System.Windows.Forms.Label labelGas;
        private System.Windows.Forms.PictureBox pictureBoxGas;
    }
}