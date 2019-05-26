namespace Ejercicios_LibroCSharp
{
    partial class MainForm
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
            this.cap9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cap10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cap9ToolStripMenuItem,
            this.cap10ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cap9ToolStripMenuItem
            // 
            this.cap9ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem,
            this.ejercicio3ToolStripMenuItem});
            this.cap9ToolStripMenuItem.Name = "cap9ToolStripMenuItem";
            this.cap9ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.cap9ToolStripMenuItem.Text = "Cap.9";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio1ToolStripMenuItem.Text = "Ejercicio 1";
            this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio1ToolStripMenuItem_Click);
            // 
            // ejercicio3ToolStripMenuItem
            // 
            this.ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
            this.ejercicio3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio3ToolStripMenuItem.Text = "Ejercicio 3";
            this.ejercicio3ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio3ToolStripMenuItem_Click);
            // 
            // cap10ToolStripMenuItem
            // 
            this.cap10ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem1,
            this.ejercicio2ToolStripMenuItem});
            this.cap10ToolStripMenuItem.Name = "cap10ToolStripMenuItem";
            this.cap10ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cap10ToolStripMenuItem.Text = "Cap.10";
            // 
            // ejercicio1ToolStripMenuItem1
            // 
            this.ejercicio1ToolStripMenuItem1.Name = "ejercicio1ToolStripMenuItem1";
            this.ejercicio1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ejercicio1ToolStripMenuItem1.Text = "Ejercicio 1";
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio2ToolStripMenuItem.Text = "Ejercicio 2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cap9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cap10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
    }
}

