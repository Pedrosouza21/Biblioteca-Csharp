namespace Biblioteca_BD_DS
{
    partial class FormConsultaGeral
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnAutor = new System.Windows.Forms.RadioButton();
            this.rdbtnEditora = new System.Windows.Forms.RadioButton();
            this.rdbtnLivros = new System.Windows.Forms.RadioButton();
            this.rdbtnGenero = new System.Windows.Forms.RadioButton();
            this.lstConsulta = new System.Windows.Forms.ListView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdbtnAutor);
            this.groupBox1.Controls.Add(this.rdbtnEditora);
            this.groupBox1.Controls.Add(this.rdbtnLivros);
            this.groupBox1.Controls.Add(this.rdbtnGenero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o que você quer consultar.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbtnAutor
            // 
            this.rdbtnAutor.AutoSize = true;
            this.rdbtnAutor.Location = new System.Drawing.Point(482, 38);
            this.rdbtnAutor.Name = "rdbtnAutor";
            this.rdbtnAutor.Size = new System.Drawing.Size(57, 20);
            this.rdbtnAutor.TabIndex = 5;
            this.rdbtnAutor.TabStop = true;
            this.rdbtnAutor.Text = "Autor";
            this.rdbtnAutor.UseVisualStyleBackColor = true;
            this.rdbtnAutor.CheckedChanged += new System.EventHandler(this.rdbtnAutor_CheckedChanged);
            // 
            // rdbtnEditora
            // 
            this.rdbtnEditora.AutoSize = true;
            this.rdbtnEditora.Location = new System.Drawing.Point(309, 38);
            this.rdbtnEditora.Name = "rdbtnEditora";
            this.rdbtnEditora.Size = new System.Drawing.Size(69, 20);
            this.rdbtnEditora.TabIndex = 4;
            this.rdbtnEditora.TabStop = true;
            this.rdbtnEditora.Text = "Editora";
            this.rdbtnEditora.UseVisualStyleBackColor = true;
            this.rdbtnEditora.CheckedChanged += new System.EventHandler(this.rdbtnEditora_CheckedChanged);
            // 
            // rdbtnLivros
            // 
            this.rdbtnLivros.AutoSize = true;
            this.rdbtnLivros.Location = new System.Drawing.Point(155, 38);
            this.rdbtnLivros.Name = "rdbtnLivros";
            this.rdbtnLivros.Size = new System.Drawing.Size(62, 20);
            this.rdbtnLivros.TabIndex = 1;
            this.rdbtnLivros.TabStop = true;
            this.rdbtnLivros.Text = "Livros";
            this.rdbtnLivros.UseVisualStyleBackColor = true;
            this.rdbtnLivros.CheckedChanged += new System.EventHandler(this.rdbtnLivros_CheckedChanged);
            // 
            // rdbtnGenero
            // 
            this.rdbtnGenero.AutoSize = true;
            this.rdbtnGenero.Location = new System.Drawing.Point(6, 38);
            this.rdbtnGenero.Name = "rdbtnGenero";
            this.rdbtnGenero.Size = new System.Drawing.Size(71, 20);
            this.rdbtnGenero.TabIndex = 0;
            this.rdbtnGenero.TabStop = true;
            this.rdbtnGenero.Text = "Gênero";
            this.rdbtnGenero.UseVisualStyleBackColor = true;
            this.rdbtnGenero.CheckedChanged += new System.EventHandler(this.rdbtnGenero_CheckedChanged);
            // 
            // lstConsulta
            // 
            this.lstConsulta.HideSelection = false;
            this.lstConsulta.Location = new System.Drawing.Point(19, 158);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(757, 313);
            this.lstConsulta.TabIndex = 2;
            this.lstConsulta.UseCompatibleStateImageBehavior = false;
            this.lstConsulta.SelectedIndexChanged += new System.EventHandler(this.lstConsulta_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(611, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Usuário";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FormConsultaGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 473);
            this.Controls.Add(this.lstConsulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultaGeral";
            this.Text = "FormConsultaGeral";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnAutor;
        private System.Windows.Forms.RadioButton rdbtnEditora;
        private System.Windows.Forms.RadioButton rdbtnLivros;
        private System.Windows.Forms.RadioButton rdbtnGenero;
        private System.Windows.Forms.ListView lstConsulta;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}