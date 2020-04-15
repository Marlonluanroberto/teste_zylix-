namespace WindowsFormsApp5
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregarArquivo = new System.Windows.Forms.Button();
            this.TXT_ARQUIVO = new System.Windows.Forms.TextBox();
            this.TXT_NOME = new System.Windows.Forms.TextBox();
            this.TXT_SOBRENOME = new System.Windows.Forms.TextBox();
            this.TXT_ENDERECO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(588, 157);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 70);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR ARQUIVO";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.salvarClick);
            // 
            // btnCarregarArquivo
            // 
            this.btnCarregarArquivo.Location = new System.Drawing.Point(588, 248);
            this.btnCarregarArquivo.Name = "btnCarregarArquivo";
            this.btnCarregarArquivo.Size = new System.Drawing.Size(200, 70);
            this.btnCarregarArquivo.TabIndex = 1;
            this.btnCarregarArquivo.Text = "CARREGAR ARQUIVO";
            this.btnCarregarArquivo.UseVisualStyleBackColor = true;
            this.btnCarregarArquivo.Click += new System.EventHandler(this.lerClick);
            // 
            // TXT_ARQUIVO
            // 
            this.TXT_ARQUIVO.Enabled = false;
            this.TXT_ARQUIVO.Location = new System.Drawing.Point(12, 183);
            this.TXT_ARQUIVO.Multiline = true;
            this.TXT_ARQUIVO.Name = "TXT_ARQUIVO";
            this.TXT_ARQUIVO.Size = new System.Drawing.Size(469, 255);
            this.TXT_ARQUIVO.TabIndex = 3;
            // 
            // TXT_NOME
            // 
            this.TXT_NOME.Location = new System.Drawing.Point(154, 36);
            this.TXT_NOME.Multiline = true;
            this.TXT_NOME.Name = "TXT_NOME";
            this.TXT_NOME.Size = new System.Drawing.Size(327, 31);
            this.TXT_NOME.TabIndex = 4;
            // 
            // TXT_SOBRENOME
            // 
            this.TXT_SOBRENOME.Location = new System.Drawing.Point(154, 85);
            this.TXT_SOBRENOME.Multiline = true;
            this.TXT_SOBRENOME.Name = "TXT_SOBRENOME";
            this.TXT_SOBRENOME.Size = new System.Drawing.Size(327, 31);
            this.TXT_SOBRENOME.TabIndex = 5;
            // 
            // TXT_ENDERECO
            // 
            this.TXT_ENDERECO.Location = new System.Drawing.Point(154, 133);
            this.TXT_ENDERECO.Multiline = true;
            this.TXT_ENDERECO.Name = "TXT_ENDERECO";
            this.TXT_ENDERECO.Size = new System.Drawing.Size(327, 31);
            this.TXT_ENDERECO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ENDERECCO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SOBRENOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_ENDERECO);
            this.Controls.Add(this.TXT_SOBRENOME);
            this.Controls.Add(this.TXT_NOME);
            this.Controls.Add(this.TXT_ARQUIVO);
            this.Controls.Add(this.btnCarregarArquivo);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregarArquivo;
        private System.Windows.Forms.TextBox TXT_ARQUIVO;
        private System.Windows.Forms.TextBox TXT_NOME;
        private System.Windows.Forms.TextBox TXT_SOBRENOME;
        private System.Windows.Forms.TextBox TXT_ENDERECO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

