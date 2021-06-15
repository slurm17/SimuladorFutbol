namespace SimuladorFutbol2
{
    partial class vLiga
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvPartidosActual = new System.Windows.Forms.DataGridView();
            this.dgvPartidosSig = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidosActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidosSig)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Jugar Fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Borrar tabla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(47, 34);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersVisible = false;
            this.dgv3.Size = new System.Drawing.Size(278, 224);
            this.dgv3.TabIndex = 11;
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pos});
            this.dgv4.Location = new System.Drawing.Point(28, 34);
            this.dgv4.Name = "dgv4";
            this.dgv4.RowHeadersVisible = false;
            this.dgv4.Size = new System.Drawing.Size(20, 224);
            this.dgv4.TabIndex = 12;
            // 
            // pos
            // 
            this.pos.Frozen = true;
            this.pos.HeaderText = "#";
            this.pos.Name = "pos";
            this.pos.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Borrar tabla fixture";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvPartidosActual
            // 
            this.dgvPartidosActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidosActual.Location = new System.Drawing.Point(331, 34);
            this.dgvPartidosActual.Name = "dgvPartidosActual";
            this.dgvPartidosActual.RowHeadersVisible = false;
            this.dgvPartidosActual.Size = new System.Drawing.Size(392, 150);
            this.dgvPartidosActual.TabIndex = 14;
            // 
            // dgvPartidosSig
            // 
            this.dgvPartidosSig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidosSig.Location = new System.Drawing.Point(331, 226);
            this.dgvPartidosSig.Name = "dgvPartidosSig";
            this.dgvPartidosSig.RowHeadersVisible = false;
            this.dgvPartidosSig.Size = new System.Drawing.Size(392, 150);
            this.dgvPartidosSig.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(232, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Fecha uno";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // vLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvPartidosSig);
            this.Controls.Add(this.dgvPartidosActual);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vLiga";
            this.Text = "vLiga";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidosActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidosSig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DataGridView dgv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvPartidosActual;
        private System.Windows.Forms.DataGridView dgvPartidosSig;
        private System.Windows.Forms.Button button5;
    }
}