namespace Seminar_9___Bun
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Generare = new System.Windows.Forms.Button();
            this.UpDownPointCount = new System.Windows.Forms.NumericUpDown();
            this.ScanareGraham = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Introduceti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPointCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 441);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Generare
            // 
            this.Generare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Generare.Location = new System.Drawing.Point(948, 27);
            this.Generare.Name = "Generare";
            this.Generare.Size = new System.Drawing.Size(134, 83);
            this.Generare.TabIndex = 1;
            this.Generare.Text = " Algoritmul lui Jarvis";
            this.Generare.UseVisualStyleBackColor = false;
            this.Generare.Click += new System.EventHandler(this.Generare_Click);
            // 
            // UpDownPointCount
            // 
            this.UpDownPointCount.Location = new System.Drawing.Point(952, 179);
            this.UpDownPointCount.Name = "UpDownPointCount";
            this.UpDownPointCount.Size = new System.Drawing.Size(130, 22);
            this.UpDownPointCount.TabIndex = 2;
            // 
            // ScanareGraham
            // 
            this.ScanareGraham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScanareGraham.Location = new System.Drawing.Point(948, 261);
            this.ScanareGraham.Name = "ScanareGraham";
            this.ScanareGraham.Size = new System.Drawing.Size(134, 84);
            this.ScanareGraham.TabIndex = 3;
            this.ScanareGraham.Text = "Scanare Graham";
            this.ScanareGraham.UseVisualStyleBackColor = false;
            this.ScanareGraham.Click += new System.EventHandler(this.ScanareGraham_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(948, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quck Hull";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Introduceti
            // 
            this.Introduceti.AutoSize = true;
            this.Introduceti.Location = new System.Drawing.Point(949, 129);
            this.Introduceti.Name = "Introduceti";
            this.Introduceti.Size = new System.Drawing.Size(153, 34);
            this.Introduceti.TabIndex = 5;
            this.Introduceti.Text = "Introduceti numarul 20 \r\nin casuta de mai jos";
            this.Introduceti.Click += new System.EventHandler(this.Introduceti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 515);
            this.Controls.Add(this.Introduceti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScanareGraham);
            this.Controls.Add(this.UpDownPointCount);
            this.Controls.Add(this.Generare);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPointCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Generare;
        private System.Windows.Forms.NumericUpDown UpDownPointCount;
        private System.Windows.Forms.Button ScanareGraham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Introduceti;
    }
}

