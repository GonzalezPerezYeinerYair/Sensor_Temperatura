namespace Sensor_Temperatura
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
            this.btnConector = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConector
            // 
            this.btnConector.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConector.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConector.Location = new System.Drawing.Point(56, 176);
            this.btnConector.Name = "btnConector";
            this.btnConector.Size = new System.Drawing.Size(145, 70);
            this.btnConector.TabIndex = 0;
            this.btnConector.Text = "Conectar";
            this.btnConector.UseVisualStyleBackColor = false;
            this.btnConector.Click += new System.EventHandler(this.btnConector_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Red;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDesconectar.Location = new System.Drawing.Point(237, 179);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(150, 67);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura maxima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura";
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Location = new System.Drawing.Point(82, 99);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(100, 20);
            this.tbLimTemp.TabIndex = 4;
            this.tbLimTemp.Click += new System.EventHandler(this.tbLimTemp_Click);
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTemp.Location = new System.Drawing.Point(275, 114);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(89, 45);
            this.lbTemp.TabIndex = 5;
            this.lbTemp.Text = "00.0";
            this.lbTemp.Click += new System.EventHandler(this.lbTemp_Click);
            // 
            // lbConexion
            // 
            this.lbConexion.AutoSize = true;
            this.lbConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConexion.Location = new System.Drawing.Point(78, 139);
            this.lbConexion.Name = "lbConexion";
            this.lbConexion.Size = new System.Drawing.Size(111, 20);
            this.lbConexion.TabIndex = 6;
            this.lbConexion.Text = "Sin conexion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(432, 312);
            this.Controls.Add(this.lbConexion);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConector;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLimTemp;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbConexion;
    }
}

