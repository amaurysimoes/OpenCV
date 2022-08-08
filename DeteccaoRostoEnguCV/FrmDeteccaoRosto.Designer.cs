
namespace DeteccaoRostoEnguCV
{
    partial class FrmDeteccaoRosto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirAWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraAWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.abrirAWebCamToolStripMenuItem,
            this.paraAWebCamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // picImagem
            // 
            this.picImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagem.Location = new System.Drawing.Point(0, 24);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(800, 426);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // abrirAWebCamToolStripMenuItem
            // 
            this.abrirAWebCamToolStripMenuItem.Name = "abrirAWebCamToolStripMenuItem";
            this.abrirAWebCamToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.abrirAWebCamToolStripMenuItem.Text = "Abrir a WebCam";
            this.abrirAWebCamToolStripMenuItem.Click += new System.EventHandler(this.abrirAWebCamToolStripMenuItem_Click);
            // 
            // paraAWebCamToolStripMenuItem
            // 
            this.paraAWebCamToolStripMenuItem.Name = "paraAWebCamToolStripMenuItem";
            this.paraAWebCamToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.paraAWebCamToolStripMenuItem.Text = "Para a WebCam";
            this.paraAWebCamToolStripMenuItem.Click += new System.EventHandler(this.paraAWebCamToolStripMenuItem_Click);
            // 
            // FrmDeteccaoRosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDeteccaoRosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detecção de Movimentos Visão Computacional";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.ToolStripMenuItem abrirAWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraAWebCamToolStripMenuItem;
    }
}

