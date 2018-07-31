namespace BatalhaRPG
{
    partial class CriarPersonagem
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbRaca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.radioClasse = new System.Windows.Forms.GroupBox();
            this.classeGuerreiro = new System.Windows.Forms.RadioButton();
            this.classeMago = new System.Windows.Forms.RadioButton();
            this.radioClasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raça: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Novo personagem";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(279, 20);
            this.txtNome.TabIndex = 3;
            // 
            // cmbRaca
            // 
            this.cmbRaca.FormattingEnabled = true;
            this.cmbRaca.Items.AddRange(new object[] {
            "Humano",
            "Elfo",
            "Anão"});
            this.cmbRaca.Location = new System.Drawing.Point(135, 166);
            this.cmbRaca.Name = "cmbRaca";
            this.cmbRaca.Size = new System.Drawing.Size(134, 21);
            this.cmbRaca.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexo: ";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(135, 213);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(134, 21);
            this.cmbSexo.TabIndex = 6;
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(478, 335);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(191, 58);
            this.btnComecar.TabIndex = 7;
            this.btnComecar.Text = "Começar!";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // radioClasse
            // 
            this.radioClasse.Controls.Add(this.classeMago);
            this.radioClasse.Controls.Add(this.classeGuerreiro);
            this.radioClasse.Location = new System.Drawing.Point(90, 271);
            this.radioClasse.Name = "radioClasse";
            this.radioClasse.Size = new System.Drawing.Size(144, 74);
            this.radioClasse.TabIndex = 8;
            this.radioClasse.TabStop = false;
            this.radioClasse.Text = "Classe";
            // 
            // classeGuerreiro
            // 
            this.classeGuerreiro.AutoSize = true;
            this.classeGuerreiro.Location = new System.Drawing.Point(21, 19);
            this.classeGuerreiro.Name = "classeGuerreiro";
            this.classeGuerreiro.Size = new System.Drawing.Size(68, 17);
            this.classeGuerreiro.TabIndex = 0;
            this.classeGuerreiro.TabStop = true;
            this.classeGuerreiro.Text = "Guerreiro";
            this.classeGuerreiro.UseVisualStyleBackColor = true;
            // 
            // classeMago
            // 
            this.classeMago.AutoSize = true;
            this.classeMago.Location = new System.Drawing.Point(21, 42);
            this.classeMago.Name = "classeMago";
            this.classeMago.Size = new System.Drawing.Size(52, 17);
            this.classeMago.TabIndex = 1;
            this.classeMago.TabStop = true;
            this.classeMago.Text = "Mago";
            this.classeMago.UseVisualStyleBackColor = true;
            // 
            // CriarPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 438);
            this.Controls.Add(this.radioClasse);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRaca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CriarPersonagem";
            this.Text = "Criar Personagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriarPersonagem_FormClosing);
            this.Load += new System.EventHandler(this.CriarPersonagem_Load);
            this.radioClasse.ResumeLayout(false);
            this.radioClasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbRaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.GroupBox radioClasse;
        private System.Windows.Forms.RadioButton classeMago;
        private System.Windows.Forms.RadioButton classeGuerreiro;
    }
}