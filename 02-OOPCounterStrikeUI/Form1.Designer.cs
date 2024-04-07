

namespace _02_OOPCounterStrikeUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpKesici = new System.Windows.Forms.GroupBox();
            this.btnBileyle = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.grpAtesli = new System.Windows.Forms.GroupBox();
            this.btnUzaklastir = new System.Windows.Forms.Button();
            this.btnYakinlastir = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAtesEt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpSarjor = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpKesici.SuspendLayout();
            this.grpAtesli.SuspendLayout();
            this.grpSarjor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpKesici
            // 
            this.grpKesici.Controls.Add(this.btnBileyle);
            this.grpKesici.Controls.Add(this.btnKes);
            this.grpKesici.Location = new System.Drawing.Point(48, 563);
            this.grpKesici.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpKesici.Name = "grpKesici";
            this.grpKesici.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpKesici.Size = new System.Drawing.Size(165, 192);
            this.grpKesici.TabIndex = 1;
            this.grpKesici.TabStop = false;
            this.grpKesici.Text = "Kesiciler";
            // 
            // btnBileyle
            // 
            this.btnBileyle.Location = new System.Drawing.Point(12, 112);
            this.btnBileyle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBileyle.Name = "btnBileyle";
            this.btnBileyle.Size = new System.Drawing.Size(125, 44);
            this.btnBileyle.TabIndex = 1;
            this.btnBileyle.Text = "Bileyle";
            this.btnBileyle.UseVisualStyleBackColor = true;
            this.btnBileyle.Click += new System.EventHandler(this.btnBileyle_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(12, 56);
            this.btnKes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(125, 44);
            this.btnKes.TabIndex = 0;
            this.btnKes.Text = "Kes";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // grpAtesli
            // 
            this.grpAtesli.Controls.Add(this.btnUzaklastir);
            this.grpAtesli.Controls.Add(this.btnYakinlastir);
            this.grpAtesli.Controls.Add(this.btnReload);
            this.grpAtesli.Controls.Add(this.btnAtesEt);
            this.grpAtesli.Location = new System.Drawing.Point(240, 563);
            this.grpAtesli.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpAtesli.Name = "grpAtesli";
            this.grpAtesli.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpAtesli.Size = new System.Drawing.Size(288, 192);
            this.grpAtesli.TabIndex = 2;
            this.grpAtesli.TabStop = false;
            this.grpAtesli.Text = "Atesliler";
            // 
            // btnUzaklastir
            // 
            this.btnUzaklastir.Location = new System.Drawing.Point(147, 94);
            this.btnUzaklastir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUzaklastir.Name = "btnUzaklastir";
            this.btnUzaklastir.Size = new System.Drawing.Size(125, 44);
            this.btnUzaklastir.TabIndex = 3;
            this.btnUzaklastir.Text = "Uzaklaştır";
            this.btnUzaklastir.UseVisualStyleBackColor = true;
            this.btnUzaklastir.Click += new System.EventHandler(this.btnUzaklastir_Click);
            // 
            // btnYakinlastir
            // 
            this.btnYakinlastir.Location = new System.Drawing.Point(147, 38);
            this.btnYakinlastir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnYakinlastir.Name = "btnYakinlastir";
            this.btnYakinlastir.Size = new System.Drawing.Size(125, 44);
            this.btnYakinlastir.TabIndex = 2;
            this.btnYakinlastir.Text = "Yakınlaştır";
            this.btnYakinlastir.UseVisualStyleBackColor = true;
            this.btnYakinlastir.Click += new System.EventHandler(this.btnYakinlastir_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(12, 96);
            this.btnReload.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(125, 44);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAtesEt
            // 
            this.btnAtesEt.Location = new System.Drawing.Point(12, 38);
            this.btnAtesEt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAtesEt.Name = "btnAtesEt";
            this.btnAtesEt.Size = new System.Drawing.Size(125, 44);
            this.btnAtesEt.TabIndex = 0;
            this.btnAtesEt.Text = "Ateş Et";
            this.btnAtesEt.UseVisualStyleBackColor = true;
            this.btnAtesEt.Click += new System.EventHandler(this.btnAtesEt_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 19);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 44);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // grpSarjor
            // 
            this.grpSarjor.Controls.Add(this.pictureBox2);
            this.grpSarjor.Controls.Add(this.progressBar1);
            this.grpSarjor.Location = new System.Drawing.Point(538, 563);
            this.grpSarjor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpSarjor.Name = "grpSarjor";
            this.grpSarjor.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpSarjor.Size = new System.Drawing.Size(250, 75);
            this.grpSarjor.TabIndex = 4;
            this.grpSarjor.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(2, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 796);
            this.Controls.Add(this.grpSarjor);
            this.Controls.Add(this.grpAtesli);
            this.Controls.Add(this.grpKesici);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpKesici.ResumeLayout(false);
            this.grpAtesli.ResumeLayout(false);
            this.grpSarjor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpKesici;
        private System.Windows.Forms.Button btnBileyle;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.GroupBox grpAtesli;
        private System.Windows.Forms.Button btnUzaklastir;
        private System.Windows.Forms.Button btnYakinlastir;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAtesEt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grpSarjor;
        private System.Windows.Forms.PictureBox pictureBox2;

        #endregion
    }
}





