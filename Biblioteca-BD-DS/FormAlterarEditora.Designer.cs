﻿
namespace Biblioteca_BD_DS
{
    partial class FormAlterarEditora
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAlterar = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomeAtt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPesquisar.Location = new System.Drawing.Point(129, 37);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(177, 24);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(49, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pesquisar";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtId.Location = new System.Drawing.Point(520, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 24);
            this.txtId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(347, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Informe o ID da editora:";
            // 
            // lstAlterar
            // 
            this.lstAlterar.HideSelection = false;
            this.lstAlterar.Location = new System.Drawing.Point(52, 78);
            this.lstAlterar.Name = "lstAlterar";
            this.lstAlterar.Size = new System.Drawing.Size(254, 150);
            this.lstAlterar.TabIndex = 11;
            this.lstAlterar.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeAtt
            // 
            this.txtNomeAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNomeAtt.Location = new System.Drawing.Point(520, 128);
            this.txtNomeAtt.Name = "txtNomeAtt";
            this.txtNomeAtt.Size = new System.Drawing.Size(197, 24);
            this.txtNomeAtt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(347, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome da Editora:";
            // 
            // FormAlterarEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 257);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAlterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomeAtt);
            this.Controls.Add(this.label1);
            this.Name = "FormAlterarEditora";
            this.Text = "FormAlterarEditora";
            this.Load += new System.EventHandler(this.FormAlterarEditora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomeAtt;
        private System.Windows.Forms.Label label1;
    }
}