namespace EsemkaCorporation._1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnMutation = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(148, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, [Name]";
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(17, 62);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(296, 30);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPromotion
            // 
            this.btnPromotion.Location = new System.Drawing.Point(17, 136);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(296, 30);
            this.btnPromotion.TabIndex = 2;
            this.btnPromotion.Text = "Apply for Job Promotion";
            this.btnPromotion.UseVisualStyleBackColor = true;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // btnMutation
            // 
            this.btnMutation.Location = new System.Drawing.Point(17, 99);
            this.btnMutation.Name = "btnMutation";
            this.btnMutation.Size = new System.Drawing.Size(296, 30);
            this.btnMutation.TabIndex = 3;
            this.btnMutation.Text = "Apply for Job Mutation";
            this.btnMutation.UseVisualStyleBackColor = true;
            this.btnMutation.Click += new System.EventHandler(this.btnMutation_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(17, 198);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(296, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 237);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMutation);
            this.Controls.Add(this.btnPromotion);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnMutation;
        private System.Windows.Forms.Button btnLogout;
    }
}