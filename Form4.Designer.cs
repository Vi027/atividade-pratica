namespace Atividade_Prática
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.númeroMaiorEMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroMaiorEMenorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesDeFutebolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.númeroMaiorEMenorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // númeroMaiorEMenorToolStripMenuItem
            // 
            this.númeroMaiorEMenorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.númeroMaiorEMenorToolStripMenuItem1,
            this.planetasToolStripMenuItem,
            this.timesDeFutebolToolStripMenuItem});
            this.númeroMaiorEMenorToolStripMenuItem.Image = global::Atividade_Prática.Properties.Resources.menu;
            this.númeroMaiorEMenorToolStripMenuItem.Name = "númeroMaiorEMenorToolStripMenuItem";
            this.númeroMaiorEMenorToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.númeroMaiorEMenorToolStripMenuItem.Text = "Atividades";
            // 
            // númeroMaiorEMenorToolStripMenuItem1
            // 
            this.númeroMaiorEMenorToolStripMenuItem1.Image = global::Atividade_Prática.Properties.Resources.html;
            this.númeroMaiorEMenorToolStripMenuItem1.Name = "númeroMaiorEMenorToolStripMenuItem1";
            this.númeroMaiorEMenorToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.númeroMaiorEMenorToolStripMenuItem1.Text = "Número maior e menor";
            this.númeroMaiorEMenorToolStripMenuItem1.Click += new System.EventHandler(this.númeroMaiorEMenorToolStripMenuItem1_Click);
            // 
            // planetasToolStripMenuItem
            // 
            this.planetasToolStripMenuItem.Image = global::Atividade_Prática.Properties.Resources.planet;
            this.planetasToolStripMenuItem.Name = "planetasToolStripMenuItem";
            this.planetasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.planetasToolStripMenuItem.Text = "Planetas";
            this.planetasToolStripMenuItem.Click += new System.EventHandler(this.planetasToolStripMenuItem_Click);
            // 
            // timesDeFutebolToolStripMenuItem
            // 
            this.timesDeFutebolToolStripMenuItem.Image = global::Atividade_Prática.Properties.Resources.soccer;
            this.timesDeFutebolToolStripMenuItem.Name = "timesDeFutebolToolStripMenuItem";
            this.timesDeFutebolToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.timesDeFutebolToolStripMenuItem.Text = "Times de futebol";
            this.timesDeFutebolToolStripMenuItem.Click += new System.EventHandler(this.timesDeFutebolToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atividade_Prática.Properties.Resources.linguagens_de_programação;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem númeroMaiorEMenorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroMaiorEMenorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesDeFutebolToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}