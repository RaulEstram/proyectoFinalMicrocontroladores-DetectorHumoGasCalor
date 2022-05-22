namespace proyectoFinalMicros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMenuOtros = new System.Windows.Forms.Button();
            this.buttonMenuManual = new System.Windows.Forms.Button();
            this.buttonMenuAutomatico = new System.Windows.Forms.Button();
            this.buttonMenuSerial = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonCloseForms = new System.Windows.Forms.Button();
            this.labelTituloPrincipal = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.panelMenu.Controls.Add(this.buttonMenuOtros);
            this.panelMenu.Controls.Add(this.buttonMenuManual);
            this.panelMenu.Controls.Add(this.buttonMenuAutomatico);
            this.panelMenu.Controls.Add(this.buttonMenuSerial);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 461);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonMenuOtros
            // 
            this.buttonMenuOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.buttonMenuOtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuOtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuOtros.FlatAppearance.BorderSize = 0;
            this.buttonMenuOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuOtros.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuOtros.ForeColor = System.Drawing.Color.White;
            this.buttonMenuOtros.Location = new System.Drawing.Point(0, 250);
            this.buttonMenuOtros.Name = "buttonMenuOtros";
            this.buttonMenuOtros.Size = new System.Drawing.Size(150, 50);
            this.buttonMenuOtros.TabIndex = 4;
            this.buttonMenuOtros.Text = "Otros";
            this.buttonMenuOtros.UseVisualStyleBackColor = false;
            this.buttonMenuOtros.Click += new System.EventHandler(this.buttonMenuOtros_Click);
            // 
            // buttonMenuManual
            // 
            this.buttonMenuManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.buttonMenuManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuManual.FlatAppearance.BorderSize = 0;
            this.buttonMenuManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuManual.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuManual.ForeColor = System.Drawing.Color.White;
            this.buttonMenuManual.Location = new System.Drawing.Point(0, 200);
            this.buttonMenuManual.Name = "buttonMenuManual";
            this.buttonMenuManual.Size = new System.Drawing.Size(150, 50);
            this.buttonMenuManual.TabIndex = 3;
            this.buttonMenuManual.Text = "Modo Manual";
            this.buttonMenuManual.UseVisualStyleBackColor = false;
            this.buttonMenuManual.Click += new System.EventHandler(this.buttonMenuManual_Click);
            // 
            // buttonMenuAutomatico
            // 
            this.buttonMenuAutomatico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.buttonMenuAutomatico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuAutomatico.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuAutomatico.FlatAppearance.BorderSize = 0;
            this.buttonMenuAutomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuAutomatico.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuAutomatico.ForeColor = System.Drawing.Color.White;
            this.buttonMenuAutomatico.Location = new System.Drawing.Point(0, 150);
            this.buttonMenuAutomatico.Name = "buttonMenuAutomatico";
            this.buttonMenuAutomatico.Size = new System.Drawing.Size(150, 50);
            this.buttonMenuAutomatico.TabIndex = 2;
            this.buttonMenuAutomatico.Text = "Modo Automatico";
            this.buttonMenuAutomatico.UseVisualStyleBackColor = false;
            this.buttonMenuAutomatico.Click += new System.EventHandler(this.buttonMenuAutomatico_Click);
            // 
            // buttonMenuSerial
            // 
            this.buttonMenuSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.buttonMenuSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuSerial.FlatAppearance.BorderSize = 0;
            this.buttonMenuSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuSerial.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuSerial.ForeColor = System.Drawing.Color.White;
            this.buttonMenuSerial.Location = new System.Drawing.Point(0, 100);
            this.buttonMenuSerial.Name = "buttonMenuSerial";
            this.buttonMenuSerial.Size = new System.Drawing.Size(150, 50);
            this.buttonMenuSerial.TabIndex = 1;
            this.buttonMenuSerial.Text = "Puerto Serial";
            this.buttonMenuSerial.UseVisualStyleBackColor = false;
            this.buttonMenuSerial.Click += new System.EventHandler(this.buttonMenuSerial_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(47)))));
            this.panelHeader.Controls.Add(this.buttonCloseForms);
            this.panelHeader.Controls.Add(this.labelTituloPrincipal);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(150, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(584, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // buttonCloseForms
            // 
            this.buttonCloseForms.BackgroundImage = global::proyectoFinalMicros.Properties.Resources.close;
            this.buttonCloseForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCloseForms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseForms.FlatAppearance.BorderSize = 0;
            this.buttonCloseForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForms.Location = new System.Drawing.Point(26, 40);
            this.buttonCloseForms.Name = "buttonCloseForms";
            this.buttonCloseForms.Size = new System.Drawing.Size(20, 20);
            this.buttonCloseForms.TabIndex = 1;
            this.buttonCloseForms.UseVisualStyleBackColor = true;
            this.buttonCloseForms.Visible = false;
            this.buttonCloseForms.Click += new System.EventHandler(this.buttonCloseForms_Click);
            // 
            // labelTituloPrincipal
            // 
            this.labelTituloPrincipal.AutoSize = true;
            this.labelTituloPrincipal.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPrincipal.ForeColor = System.Drawing.Color.White;
            this.labelTituloPrincipal.Location = new System.Drawing.Point(62, 30);
            this.labelTituloPrincipal.Name = "labelTituloPrincipal";
            this.labelTituloPrincipal.Size = new System.Drawing.Size(135, 43);
            this.labelTituloPrincipal.TabIndex = 0;
            this.labelTituloPrincipal.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.White;
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.ForeColor = System.Drawing.Color.Cornsilk;
            this.panelDesktopPanel.Location = new System.Drawing.Point(150, 100);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(584, 361);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoFinalMicros.Properties.Resources.ranni_ranni_the_witch;
            this.pictureBox1.Location = new System.Drawing.Point(275, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button buttonMenuOtros;
        private System.Windows.Forms.Button buttonMenuManual;
        private System.Windows.Forms.Button buttonMenuAutomatico;
        private System.Windows.Forms.Button buttonMenuSerial;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelTituloPrincipal;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonCloseForms;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

