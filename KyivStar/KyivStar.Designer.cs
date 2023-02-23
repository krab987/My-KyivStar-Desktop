namespace KyivStar
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.головнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.послугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профільToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головнаToolStripMenuItem,
            this.тарифиToolStripMenuItem,
            this.послугиToolStripMenuItem,
            this.профільToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(1032, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // головнаToolStripMenuItem
            // 
            this.головнаToolStripMenuItem.Name = "головнаToolStripMenuItem";
            this.головнаToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.головнаToolStripMenuItem.Text = "Головна";
            // 
            // тарифиToolStripMenuItem
            // 
            this.тарифиToolStripMenuItem.Name = "тарифиToolStripMenuItem";
            this.тарифиToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.тарифиToolStripMenuItem.Text = "Тарифи";
            // 
            // послугиToolStripMenuItem
            // 
            this.послугиToolStripMenuItem.Name = "послугиToolStripMenuItem";
            this.послугиToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.послугиToolStripMenuItem.Text = "Послуги";
            // 
            // профільToolStripMenuItem
            // 
            this.профільToolStripMenuItem.Name = "профільToolStripMenuItem";
            this.профільToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.профільToolStripMenuItem.Text = "Профіль";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 541);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainForm";
            this.Text = "KyivStar Desktop";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem головнаToolStripMenuItem;
        private ToolStripMenuItem тарифиToolStripMenuItem;
        private ToolStripMenuItem послугиToolStripMenuItem;
        private ToolStripMenuItem профільToolStripMenuItem;
    }
}