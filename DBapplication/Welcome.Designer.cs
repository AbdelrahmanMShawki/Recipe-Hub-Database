namespace DBapplication
{
    partial class Welcome
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
            this.TopLeftPic = new System.Windows.Forms.PictureBox();
            this.TopRightPic = new System.Windows.Forms.PictureBox();
            this.BottomRightPic = new System.Windows.Forms.PictureBox();
            this.BottomLeftPic = new System.Windows.Forms.PictureBox();
            this.TheLabel = new System.Windows.Forms.Label();
            this.HubLabel = new System.Windows.Forms.Label();
            this.RecipeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLeftPic
            // 
            this.TopLeftPic.Location = new System.Drawing.Point(-91, -53);
            this.TopLeftPic.Name = "TopLeftPic";
            this.TopLeftPic.Size = new System.Drawing.Size(246, 194);
            this.TopLeftPic.TabIndex = 0;
            this.TopLeftPic.TabStop = false;
            // 
            // TopRightPic
            // 
            this.TopRightPic.Location = new System.Drawing.Point(524, -53);
            this.TopRightPic.Name = "TopRightPic";
            this.TopRightPic.Size = new System.Drawing.Size(246, 194);
            this.TopRightPic.TabIndex = 1;
            this.TopRightPic.TabStop = false;
            // 
            // BottomRightPic
            // 
            this.BottomRightPic.Location = new System.Drawing.Point(524, 352);
            this.BottomRightPic.Name = "BottomRightPic";
            this.BottomRightPic.Size = new System.Drawing.Size(246, 194);
            this.BottomRightPic.TabIndex = 2;
            this.BottomRightPic.TabStop = false;
            // 
            // BottomLeftPic
            // 
            this.BottomLeftPic.Location = new System.Drawing.Point(-91, 352);
            this.BottomLeftPic.Name = "BottomLeftPic";
            this.BottomLeftPic.Size = new System.Drawing.Size(246, 194);
            this.BottomLeftPic.TabIndex = 3;
            this.BottomLeftPic.TabStop = false;
            // 
            // TheLabel
            // 
            this.TheLabel.BackColor = System.Drawing.Color.Transparent;
            this.TheLabel.Font = new System.Drawing.Font("Anaktoria", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLabel.Location = new System.Drawing.Point(180, 88);
            this.TheLabel.Name = "TheLabel";
            this.TheLabel.Size = new System.Drawing.Size(139, 68);
            this.TheLabel.TabIndex = 4;
            this.TheLabel.Text = "The";
            this.TheLabel.Click += new System.EventHandler(this.MyLabel_Click);
            // 
            // HubLabel
            // 
            this.HubLabel.AutoSize = true;
            this.HubLabel.Font = new System.Drawing.Font("Anaktoria", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HubLabel.Location = new System.Drawing.Point(423, 226);
            this.HubLabel.Name = "HubLabel";
            this.HubLabel.Size = new System.Drawing.Size(131, 74);
            this.HubLabel.TabIndex = 6;
            this.HubLabel.Text = "Hub";
            this.HubLabel.Click += new System.EventHandler(this.HubLabel_Click);
            // 
            // RecipeLabel
            // 
            this.RecipeLabel.AutoSize = true;
            this.RecipeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RecipeLabel.Font = new System.Drawing.Font("Anaktoria", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeLabel.Location = new System.Drawing.Point(231, 133);
            this.RecipeLabel.Name = "RecipeLabel";
            this.RecipeLabel.Size = new System.Drawing.Size(331, 149);
            this.RecipeLabel.TabIndex = 7;
            this.RecipeLabel.Text = "Recipe";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Anaktoria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(383, 330);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(130, 65);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseEnter += new System.EventHandler(this.LoginButton_MouseEnter);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Anaktoria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(195, 330);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(130, 65);
            this.SignUpButton.TabIndex = 9;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(699, 492);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.HubLabel);
            this.Controls.Add(this.TheLabel);
            this.Controls.Add(this.RecipeLabel);
            this.Controls.Add(this.BottomLeftPic);
            this.Controls.Add(this.BottomRightPic);
            this.Controls.Add(this.TopRightPic);
            this.Controls.Add(this.TopLeftPic);
            this.Font = new System.Drawing.Font("Anaktoria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopLeftPic;
        private System.Windows.Forms.PictureBox TopRightPic;
        private System.Windows.Forms.PictureBox BottomRightPic;
        private System.Windows.Forms.PictureBox BottomLeftPic;
        private System.Windows.Forms.Label TheLabel;
        private System.Windows.Forms.Label HubLabel;
        private System.Windows.Forms.Label RecipeLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
    }
}