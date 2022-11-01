namespace Windows
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
            this.btnPiano = new System.Windows.Forms.Button();
            this.btnViolin = new System.Windows.Forms.Button();
            this.btnGuitarra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPiano
            // 
            this.btnPiano.Location = new System.Drawing.Point(292, 68);
            this.btnPiano.Name = "btnPiano";
            this.btnPiano.Size = new System.Drawing.Size(133, 23);
            this.btnPiano.TabIndex = 0;
            this.btnPiano.Text = "Afinar Piano";
            this.btnPiano.UseVisualStyleBackColor = true;
            this.btnPiano.Click += new System.EventHandler(this.btnPiano_Click);
            // 
            // btnViolin
            // 
            this.btnViolin.Location = new System.Drawing.Point(292, 126);
            this.btnViolin.Name = "btnViolin";
            this.btnViolin.Size = new System.Drawing.Size(133, 23);
            this.btnViolin.TabIndex = 1;
            this.btnViolin.Text = "Afinar Violin";
            this.btnViolin.UseVisualStyleBackColor = true;
            this.btnViolin.Click += new System.EventHandler(this.btnViolin_Click);
            // 
            // btnGuitarra
            // 
            this.btnGuitarra.Location = new System.Drawing.Point(292, 181);
            this.btnGuitarra.Name = "btnGuitarra";
            this.btnGuitarra.Size = new System.Drawing.Size(133, 23);
            this.btnGuitarra.TabIndex = 2;
            this.btnGuitarra.Text = "Afinar Guitarra";
            this.btnGuitarra.UseVisualStyleBackColor = true;
            this.btnGuitarra.Click += new System.EventHandler(this.btnGuitarra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuitarra);
            this.Controls.Add(this.btnViolin);
            this.Controls.Add(this.btnPiano);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPiano;
        private System.Windows.Forms.Button btnViolin;
        private System.Windows.Forms.Button btnGuitarra;
    }
}

