﻿namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    partial class CDeputadoFederal
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
            this.txtNomeDeputadoFederal = new System.Windows.Forms.TextBox();
            this.txtNumDeputadoFederal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntCadastrarPresidente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNomeDeputadoFederal
            // 
            this.txtNomeDeputadoFederal.Location = new System.Drawing.Point(211, 213);
            this.txtNomeDeputadoFederal.Name = "txtNomeDeputadoFederal";
            this.txtNomeDeputadoFederal.Size = new System.Drawing.Size(226, 20);
            this.txtNomeDeputadoFederal.TabIndex = 17;
            // 
            // txtNumDeputadoFederal
            // 
            this.txtNumDeputadoFederal.Location = new System.Drawing.Point(227, 163);
            this.txtNumDeputadoFederal.Name = "txtNumDeputadoFederal";
            this.txtNumDeputadoFederal.Size = new System.Drawing.Size(62, 20);
            this.txtNumDeputadoFederal.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cadastrando Deputado Federal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Numero do Candidato: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Candidato: ";
            // 
            // bntCadastrarPresidente
            // 
            this.bntCadastrarPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastrarPresidente.Location = new System.Drawing.Point(199, 304);
            this.bntCadastrarPresidente.Name = "bntCadastrarPresidente";
            this.bntCadastrarPresidente.Size = new System.Drawing.Size(111, 36);
            this.bntCadastrarPresidente.TabIndex = 12;
            this.bntCadastrarPresidente.Text = "Cadastrar";
            this.bntCadastrarPresidente.UseVisualStyleBackColor = true;
            this.bntCadastrarPresidente.Click += new System.EventHandler(this.BntCadastrarPresidente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Estado: ";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG",
            "ES",
            "BA",
            "AM",
            "AC",
            "AL",
            "GO",
            "MS",
            "DF"});
            this.ComboBox.Location = new System.Drawing.Point(120, 257);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 18;
            // 
            // CDeputadoFederal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.txtNomeDeputadoFederal);
            this.Controls.Add(this.txtNumDeputadoFederal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCadastrarPresidente);
            this.Name = "CDeputadoFederal";
            this.Text = "CDeputadoFederal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDeputadoFederal;
        private System.Windows.Forms.TextBox txtNumDeputadoFederal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCadastrarPresidente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox;
    }
}