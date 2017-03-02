namespace Roguelike
{
    partial class FrmMain
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPlayerHealth = new System.Windows.Forms.TextBox();
            this.txtEnemyName = new System.Windows.Forms.TextBox();
            this.txtEnemyHealth = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(27, 61);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 0;
            // 
            // txtPlayerHealth
            // 
            this.txtPlayerHealth.Location = new System.Drawing.Point(27, 97);
            this.txtPlayerHealth.Name = "txtPlayerHealth";
            this.txtPlayerHealth.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerHealth.TabIndex = 1;
            // 
            // txtEnemyName
            // 
            this.txtEnemyName.Location = new System.Drawing.Point(172, 61);
            this.txtEnemyName.Name = "txtEnemyName";
            this.txtEnemyName.Size = new System.Drawing.Size(100, 20);
            this.txtEnemyName.TabIndex = 2;
            // 
            // txtEnemyHealth
            // 
            this.txtEnemyHealth.Location = new System.Drawing.Point(172, 97);
            this.txtEnemyHealth.Name = "txtEnemyHealth";
            this.txtEnemyHealth.Size = new System.Drawing.Size(100, 20);
            this.txtEnemyHealth.TabIndex = 3;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(113, 152);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(36, 45);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(52, 81);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(41, 13);
            this.lblPlayerHealth.TabIndex = 6;
            this.lblPlayerHealth.Text = "Health:";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(197, 45);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(73, 13);
            this.lblEnemyName.TabIndex = 7;
            this.lblEnemyName.Text = "Enemy Name:";
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Location = new System.Drawing.Point(197, 81);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(41, 13);
            this.lblEnemyHealth.TabIndex = 8;
            this.lblEnemyHealth.Text = "Health:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 384);
            this.Controls.Add(this.lblEnemyHealth);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txtEnemyHealth);
            this.Controls.Add(this.txtEnemyName);
            this.Controls.Add(this.txtPlayerHealth);
            this.Controls.Add(this.txtPlayerName);
            this.Name = "FrmMain";
            this.Text = "Roguelike v0.0";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtPlayerHealth;
        private System.Windows.Forms.TextBox txtEnemyName;
        private System.Windows.Forms.TextBox txtEnemyHealth;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblEnemyHealth;
    }
}

