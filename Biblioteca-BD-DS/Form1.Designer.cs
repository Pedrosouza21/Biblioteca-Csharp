
namespace Biblioteca_BD_DS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarGêneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEditoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaTabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genêroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLivroToolStripMenuItem,
            this.cadastrarAutorToolStripMenuItem,
            this.cadastrarGêneroToolStripMenuItem,
            this.cadastrarEditoraToolStripMenuItem,
            this.cadastrarUsuárioToolStripMenuItem,
            this.fazerEmpréstimoToolStripMenuItem,
            this.consultaTabelasToolStripMenuItem,
            this.devolverLivroToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // cadastrarLivroToolStripMenuItem
            // 
            this.cadastrarLivroToolStripMenuItem.Name = "cadastrarLivroToolStripMenuItem";
            this.cadastrarLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarLivroToolStripMenuItem.Text = "Livro";
            this.cadastrarLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLivroToolStripMenuItem_Click_1);
            // 
            // cadastrarAutorToolStripMenuItem
            // 
            this.cadastrarAutorToolStripMenuItem.Name = "cadastrarAutorToolStripMenuItem";
            this.cadastrarAutorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAutorToolStripMenuItem.Text = "Autor";
            this.cadastrarAutorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAutorToolStripMenuItem_Click_1);
            // 
            // cadastrarGêneroToolStripMenuItem
            // 
            this.cadastrarGêneroToolStripMenuItem.Name = "cadastrarGêneroToolStripMenuItem";
            this.cadastrarGêneroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarGêneroToolStripMenuItem.Text = "Gênero";
            this.cadastrarGêneroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarGêneroToolStripMenuItem_Click_1);
            // 
            // cadastrarEditoraToolStripMenuItem
            // 
            this.cadastrarEditoraToolStripMenuItem.Name = "cadastrarEditoraToolStripMenuItem";
            this.cadastrarEditoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarEditoraToolStripMenuItem.Text = "Editora";
            this.cadastrarEditoraToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEditoraToolStripMenuItem_Click_1);
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // fazerEmpréstimoToolStripMenuItem
            // 
            this.fazerEmpréstimoToolStripMenuItem.Name = "fazerEmpréstimoToolStripMenuItem";
            this.fazerEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fazerEmpréstimoToolStripMenuItem.Text = "Fazer empréstimo";
            this.fazerEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.fazerEmpréstimoToolStripMenuItem_Click);
            // 
            // consultaTabelasToolStripMenuItem
            // 
            this.consultaTabelasToolStripMenuItem.Name = "consultaTabelasToolStripMenuItem";
            this.consultaTabelasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaTabelasToolStripMenuItem.Text = "Consultar tabelas";
            this.consultaTabelasToolStripMenuItem.Click += new System.EventHandler(this.consultaTabelasToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem,
            this.editoraToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.livroToolStripMenuItem,
            this.genêroToolStripMenuItem});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // editoraToolStripMenuItem
            // 
            this.editoraToolStripMenuItem.Name = "editoraToolStripMenuItem";
            this.editoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editoraToolStripMenuItem.Text = "Editora";
            this.editoraToolStripMenuItem.Click += new System.EventHandler(this.editoraToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livroToolStripMenuItem.Text = "Livro";
            this.livroToolStripMenuItem.Click += new System.EventHandler(this.livroToolStripMenuItem_Click);
            // 
            // genêroToolStripMenuItem
            // 
            this.genêroToolStripMenuItem.Name = "genêroToolStripMenuItem";
            this.genêroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genêroToolStripMenuItem.Text = "Genêro";
            this.genêroToolStripMenuItem.Click += new System.EventHandler(this.genêroToolStripMenuItem_Click);
            // 
            // devolverLivroToolStripMenuItem
            // 
            this.devolverLivroToolStripMenuItem.Name = "devolverLivroToolStripMenuItem";
            this.devolverLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devolverLivroToolStripMenuItem.Text = "Devolver Livro";
            this.devolverLivroToolStripMenuItem.Click += new System.EventHandler(this.devolverLivroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 200);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarGêneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEditoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaTabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genêroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverLivroToolStripMenuItem;
    }
}

