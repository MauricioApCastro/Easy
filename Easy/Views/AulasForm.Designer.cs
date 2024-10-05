namespace Easy.Views
{
    partial class AulasForm
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
            this.Tela = new System.Windows.Forms.PictureBox();
            this.btnAudio = new System.Windows.Forms.Button();
            this.lblPortugues = new System.Windows.Forms.Label();
            this.lblIngles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tela)).BeginInit();
            this.SuspendLayout();
            // 
            // Tela
            // 
            this.Tela.Location = new System.Drawing.Point(12, 12);
            this.Tela.Name = "Tela";
            this.Tela.Size = new System.Drawing.Size(338, 219);
            this.Tela.TabIndex = 0;
            this.Tela.TabStop = false;
            // 
            // btnAudio
            // 
            this.btnAudio.Location = new System.Drawing.Point(581, 48);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(75, 40);
            this.btnAudio.TabIndex = 1;
            this.btnAudio.Text = "áudio";
            this.btnAudio.UseVisualStyleBackColor = true;
            // 
            // lblPortugues
            // 
            this.lblPortugues.AutoSize = true;
            this.lblPortugues.Location = new System.Drawing.Point(154, 300);
            this.lblPortugues.Name = "lblPortugues";
            this.lblPortugues.Size = new System.Drawing.Size(146, 20);
            this.lblPortugues.TabIndex = 2;
            this.lblPortugues.Text = "texto em português";
            // 
            // lblIngles
            // 
            this.lblIngles.AutoSize = true;
            this.lblIngles.Location = new System.Drawing.Point(154, 355);
            this.lblIngles.Name = "lblIngles";
            this.lblIngles.Size = new System.Drawing.Size(115, 20);
            this.lblIngles.TabIndex = 3;
            this.lblIngles.Text = "texto em ingles\r\n";
            // 
            // AulasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIngles);
            this.Controls.Add(this.lblPortugues);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.Tela);
            this.Name = "AulasForm";
            this.Text = "Aula";
            ((System.ComponentModel.ISupportInitialize)(this.Tela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Tela;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Label lblPortugues;
        private System.Windows.Forms.Label lblIngles;
    }
}