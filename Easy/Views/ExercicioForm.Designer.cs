namespace Easy.Views
{
    partial class ExercicioForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExercicioForm));
            this.btnFalar = new System.Windows.Forms.Button();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblPt = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.timerFalar = new System.Windows.Forms.Timer(this.components);
            this.btnOuvir = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.pictureBoxTela = new System.Windows.Forms.PictureBox();
            this.timerOuvir = new System.Windows.Forms.Timer(this.components);
            this.timerEscrever = new System.Windows.Forms.Timer(this.components);
            this.textBoxProfessor = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEscrever = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFalar
            // 
            this.btnFalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFalar.BackColor = System.Drawing.Color.Transparent;
            this.btnFalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFalar.FlatAppearance.BorderSize = 0;
            this.btnFalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalar.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFalar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFalar.Location = new System.Drawing.Point(35, 91);
            this.btnFalar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFalar.Name = "btnFalar";
            this.btnFalar.Size = new System.Drawing.Size(336, 90);
            this.btnFalar.TabIndex = 23;
            this.btnFalar.Text = "Falar";
            this.btnFalar.UseVisualStyleBackColor = false;
            this.btnFalar.Click += new System.EventHandler(this.btnFalar_Click_1);
            // 
            // lblEn
            // 
            this.lblEn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEn.AutoSize = true;
            this.lblEn.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold);
            this.lblEn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEn.Location = new System.Drawing.Point(3, 456);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(851, 41);
            this.lblEn.TabIndex = 4;
            this.lblEn.Text = "texto inglês";
            this.lblEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPt
            // 
            this.lblPt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPt.AutoSize = true;
            this.lblPt.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold);
            this.lblPt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPt.Location = new System.Drawing.Point(464, 670);
            this.lblPt.Name = "lblPt";
            this.lblPt.Size = new System.Drawing.Size(388, 65);
            this.lblPt.TabIndex = 5;
            this.lblPt.Text = "texto português";
            this.lblPt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.Location = new System.Drawing.Point(214, 675);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(173, 65);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código\r\n";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // timerFalar
            // 
            this.timerFalar.Interval = 1000;
            this.timerFalar.Tick += new System.EventHandler(this.timerFalar_Tick);
            // 
            // btnOuvir
            // 
            this.btnOuvir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOuvir.BackColor = System.Drawing.Color.Transparent;
            this.btnOuvir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOuvir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOuvir.FlatAppearance.BorderSize = 0;
            this.btnOuvir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOuvir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOuvir.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOuvir.ForeColor = System.Drawing.Color.Transparent;
            this.btnOuvir.Location = new System.Drawing.Point(87, 5);
            this.btnOuvir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOuvir.Name = "btnOuvir";
            this.btnOuvir.Size = new System.Drawing.Size(232, 71);
            this.btnOuvir.TabIndex = 1;
            this.btnOuvir.Text = "Ouvir";
            this.btnOuvir.UseVisualStyleBackColor = false;
            this.btnOuvir.Click += new System.EventHandler(this.btnOuvir_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProxima.AutoSize = true;
            this.btnProxima.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProxima.BackColor = System.Drawing.Color.Transparent;
            this.btnProxima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProxima.FlatAppearance.BorderSize = 0;
            this.btnProxima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProxima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxima.ForeColor = System.Drawing.Color.Transparent;
            this.btnProxima.Image = global::Easy.Properties.Resources.forward_arrow_right_111661;
            this.btnProxima.Location = new System.Drawing.Point(270, 371);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(134, 134);
            this.btnProxima.TabIndex = 7;
            this.btnProxima.UseVisualStyleBackColor = false;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // pictureBoxTela
            // 
            this.pictureBoxTela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTela.Image = global::Easy.Properties.Resources.coffee1;
            this.pictureBoxTela.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTela.Name = "pictureBoxTela";
            this.pictureBoxTela.Size = new System.Drawing.Size(851, 450);
            this.pictureBoxTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTela.TabIndex = 0;
            this.pictureBoxTela.TabStop = false;
            this.pictureBoxTela.Click += new System.EventHandler(this.pictureBoxTela_Click);
            // 
            // timerOuvir
            // 
            this.timerOuvir.Enabled = true;
            this.timerOuvir.Interval = 1000;
            this.timerOuvir.Tick += new System.EventHandler(this.timerOuvir_Tick);
            // 
            // timerEscrever
            // 
            this.timerEscrever.Interval = 1000;
            this.timerEscrever.Tick += new System.EventHandler(this.timerEscrever_Tick);
            // 
            // textBoxProfessor
            // 
            this.textBoxProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(217)))));
            this.textBoxProfessor.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfessor.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxProfessor.Location = new System.Drawing.Point(125, 816);
            this.textBoxProfessor.Name = "textBoxProfessor";
            this.textBoxProfessor.Size = new System.Drawing.Size(753, 73);
            this.textBoxProfessor.TabIndex = 25;
            this.textBoxProfessor.Visible = false;
            this.textBoxProfessor.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(884, 706);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 34);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // btnEscrever
            // 
            this.btnEscrever.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEscrever.BackColor = System.Drawing.Color.Transparent;
            this.btnEscrever.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscrever.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscrever.FlatAppearance.BorderSize = 0;
            this.btnEscrever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscrever.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEscrever.ForeColor = System.Drawing.Color.Transparent;
            this.btnEscrever.Location = new System.Drawing.Point(43, 211);
            this.btnEscrever.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(320, 89);
            this.btnEscrever.TabIndex = 24;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = false;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 671);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1276, 514);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblEn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxTela, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.70306F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.296944F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(857, 508);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnFalar, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnEscrever, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnProxima, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.btnOuvir, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(866, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.65734F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.34266F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(407, 508);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // ExercicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(217)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxProfessor);
            this.Controls.Add(this.lblPt);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblCodigo);
            this.Name = "ExercicioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Aula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTela;
        private System.Windows.Forms.Button btnFalar;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblPt;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnProxima;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timerFalar;
        private System.Windows.Forms.Button btnOuvir;
        private System.Windows.Forms.Timer timerOuvir;
        private System.Windows.Forms.Timer timerEscrever;
        private System.Windows.Forms.TextBox textBoxProfessor;
        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}