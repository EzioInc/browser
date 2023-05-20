namespace Ezio_Browser
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonPrécédent = new System.Windows.Forms.Button();
            this.buttonRafraichire = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.AdressBar = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.acceuilToolStripMenuItem.Text = "acceuil";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 99);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(784, 461);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri(" https://duckduckgo.com", System.UriKind.Absolute);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(709, 68);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(75, 23);
            this.buttonSuivant.TabIndex = 2;
            this.buttonSuivant.Text = "suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            // 
            // buttonPrécédent
            // 
            this.buttonPrécédent.Location = new System.Drawing.Point(628, 68);
            this.buttonPrécédent.Name = "buttonPrécédent";
            this.buttonPrécédent.Size = new System.Drawing.Size(75, 23);
            this.buttonPrécédent.TabIndex = 3;
            this.buttonPrécédent.Text = "précédent";
            this.buttonPrécédent.UseVisualStyleBackColor = true;
            // 
            // buttonRafraichire
            // 
            this.buttonRafraichire.Location = new System.Drawing.Point(93, 68);
            this.buttonRafraichire.Name = "buttonRafraichire";
            this.buttonRafraichire.Size = new System.Drawing.Size(75, 23);
            this.buttonRafraichire.TabIndex = 4;
            this.buttonRafraichire.Text = "rafraichire";
            this.buttonRafraichire.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(12, 68);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // AdressBar
            // 
            this.AdressBar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressBar.Location = new System.Drawing.Point(93, 28);
            this.AdressBar.Name = "AdressBar";
            this.AdressBar.Size = new System.Drawing.Size(610, 26);
            this.AdressBar.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AdressBar);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRafraichire);
            this.Controls.Add(this.buttonPrécédent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezio browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acceuilToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonPrécédent;
        private System.Windows.Forms.Button buttonRafraichire;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox AdressBar;
    }
}

