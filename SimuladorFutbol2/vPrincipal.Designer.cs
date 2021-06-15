namespace SimuladorFutbol2
{
    partial class vPrincipal
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
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labEquipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONAR EQUIPO";
            // 
            // btnIzq
            // 
            this.btnIzq.Location = new System.Drawing.Point(37, 185);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(75, 23);
            this.btnIzq.TabIndex = 1;
            this.btnIzq.Text = "<";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnDer
            // 
            this.btnDer.Location = new System.Drawing.Point(542, 198);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(75, 23);
            this.btnDer.TabIndex = 2;
            this.btnDer.Text = ">";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(297, 284);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labEquipo
            // 
            this.labEquipo.AutoSize = true;
            this.labEquipo.Location = new System.Drawing.Point(326, 195);
            this.labEquipo.Name = "labEquipo";
            this.labEquipo.Size = new System.Drawing.Size(35, 13);
            this.labEquipo.TabIndex = 4;
            this.labEquipo.Text = "label2";
            // 
            // vPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 360);
            this.ControlBox = false;
            this.Controls.Add(this.labEquipo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Label labEquipo;
    }
}