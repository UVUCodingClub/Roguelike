namespace Roguelike
{
    partial class frmShop
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnPotionBuy = new System.Windows.Forms.Button();
            this.lblPotionBuy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnPotionBuy
            // 
            this.btnPotionBuy.Location = new System.Drawing.Point(26, 49);
            this.btnPotionBuy.Name = "btnPotionBuy";
            this.btnPotionBuy.Size = new System.Drawing.Size(75, 32);
            this.btnPotionBuy.TabIndex = 0;
            this.btnPotionBuy.Text = "Buy 1";
            this.btnPotionBuy.UseVisualStyleBackColor = true;
            this.btnPotionBuy.Click += new System.EventHandler(this.btnPotionBuy_Click);
            // 
            // lblPotionBuy
            // 
            this.lblPotionBuy.AutoSize = true;
            this.lblPotionBuy.Location = new System.Drawing.Point(34, 33);
            this.lblPotionBuy.Name = "lblPotionBuy";
            this.lblPotionBuy.Size = new System.Drawing.Size(58, 13);
            this.lblPotionBuy.TabIndex = 1;
            this.lblPotionBuy.Text = "Potion 10g";
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPotionBuy);
            this.Controls.Add(this.btnPotionBuy);
            this.Name = "frmShop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblPotionBuy;
        private System.Windows.Forms.Button btnPotionBuy;
    }
}