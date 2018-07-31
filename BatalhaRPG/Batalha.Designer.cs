namespace BatalhaRPG
{
    partial class Batalha
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.btnMagia = new System.Windows.Forms.Button();
            this.btnDefesa = new System.Windows.Forms.Button();
            this.btnCura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.ListBox();
            this.vidaDragao = new System.Windows.Forms.ProgressBar();
            this.vidaProtagonista = new System.Windows.Forms.ProgressBar();
            this.magiaProtagonista = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.lblTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "<NOME>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vida: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Magia: ";
            // 
            // btnAtaque
            // 
            this.btnAtaque.Location = new System.Drawing.Point(238, 56);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(75, 23);
            this.btnAtaque.TabIndex = 10;
            this.btnAtaque.Text = "Ataque";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // btnMagia
            // 
            this.btnMagia.Location = new System.Drawing.Point(337, 56);
            this.btnMagia.Name = "btnMagia";
            this.btnMagia.Size = new System.Drawing.Size(75, 23);
            this.btnMagia.TabIndex = 11;
            this.btnMagia.Text = "Magia";
            this.btnMagia.UseVisualStyleBackColor = true;
            this.btnMagia.Click += new System.EventHandler(this.btnMagia_Click);
            // 
            // btnDefesa
            // 
            this.btnDefesa.Location = new System.Drawing.Point(238, 97);
            this.btnDefesa.Name = "btnDefesa";
            this.btnDefesa.Size = new System.Drawing.Size(75, 23);
            this.btnDefesa.TabIndex = 12;
            this.btnDefesa.Text = "Defesa";
            this.btnDefesa.UseVisualStyleBackColor = true;
            this.btnDefesa.Click += new System.EventHandler(this.btnDefesa_Click);
            // 
            // btnCura
            // 
            this.btnCura.Location = new System.Drawing.Point(337, 97);
            this.btnCura.Name = "btnCura";
            this.btnCura.Size = new System.Drawing.Size(75, 23);
            this.btnCura.TabIndex = 13;
            this.btnCura.Text = "Cura";
            this.btnCura.UseVisualStyleBackColor = true;
            this.btnCura.Click += new System.EventHandler(this.btnCura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vidaDragao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(540, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "inimigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "DRAGÃO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vida: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Controls.Add(this.magiaProtagonista);
            this.lblTitulo.Controls.Add(this.vidaProtagonista);
            this.lblTitulo.Controls.Add(this.lblNome);
            this.lblTitulo.Controls.Add(this.btnCura);
            this.lblTitulo.Controls.Add(this.label2);
            this.lblTitulo.Controls.Add(this.btnDefesa);
            this.lblTitulo.Controls.Add(this.label3);
            this.lblTitulo.Controls.Add(this.btnMagia);
            this.lblTitulo.Controls.Add(this.btnAtaque);
            this.lblTitulo.Location = new System.Drawing.Point(13, 302);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(470, 134);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = "<herói>";
            // 
            // log
            // 
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(29, 13);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(267, 225);
            this.log.TabIndex = 16;
            // 
            // vidaDragao
            // 
            this.vidaDragao.Location = new System.Drawing.Point(102, 65);
            this.vidaDragao.Name = "vidaDragao";
            this.vidaDragao.Size = new System.Drawing.Size(100, 23);
            this.vidaDragao.TabIndex = 17;
            this.vidaDragao.Value = 100;
            // 
            // vidaProtagonista
            // 
            this.vidaProtagonista.Location = new System.Drawing.Point(79, 56);
            this.vidaProtagonista.Name = "vidaProtagonista";
            this.vidaProtagonista.Size = new System.Drawing.Size(100, 23);
            this.vidaProtagonista.TabIndex = 14;
            this.vidaProtagonista.Value = 100;
            // 
            // magiaProtagonista
            // 
            this.magiaProtagonista.ForeColor = System.Drawing.Color.Blue;
            this.magiaProtagonista.Location = new System.Drawing.Point(79, 93);
            this.magiaProtagonista.Name = "magiaProtagonista";
            this.magiaProtagonista.Size = new System.Drawing.Size(100, 23);
            this.magiaProtagonista.TabIndex = 15;
            this.magiaProtagonista.Value = 100;
            // 
            // Batalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 448);
            this.Controls.Add(this.log);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Batalha";
            this.Text = "Batalha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Batalha_FormClosing);
            this.Load += new System.EventHandler(this.Batalha_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lblTitulo.ResumeLayout(false);
            this.lblTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Button btnMagia;
        private System.Windows.Forms.Button btnDefesa;
        private System.Windows.Forms.Button btnCura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox lblTitulo;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.ProgressBar vidaDragao;
        private System.Windows.Forms.ProgressBar magiaProtagonista;
        private System.Windows.Forms.ProgressBar vidaProtagonista;
    }
}