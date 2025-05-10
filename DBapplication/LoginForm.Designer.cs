namespace DBapplication
{
    partial class LoginForm
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
            this.TopRightPic = new System.Windows.Forms.PictureBox();
            this.TopLeftPic = new System.Windows.Forms.PictureBox();
            this.BottomLeftPic = new System.Windows.Forms.PictureBox();
            this.BottomRightPic = new System.Windows.Forms.PictureBox();
            this.AreYouLabel = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ShowPasswordCB = new System.Windows.Forms.CheckBox();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopRightPic
            // 
            this.TopRightPic.Location = new System.Drawing.Point(657, -57);
            this.TopRightPic.Name = "TopRightPic";
            this.TopRightPic.Size = new System.Drawing.Size(246, 194);
            this.TopRightPic.TabIndex = 2;
            this.TopRightPic.TabStop = false;
            // 
            // TopLeftPic
            // 
            this.TopLeftPic.Location = new System.Drawing.Point(-85, -57);
            this.TopLeftPic.Name = "TopLeftPic";
            this.TopLeftPic.Size = new System.Drawing.Size(246, 194);
            this.TopLeftPic.TabIndex = 3;
            this.TopLeftPic.TabStop = false;
            // 
            // BottomLeftPic
            // 
            this.BottomLeftPic.Location = new System.Drawing.Point(-85, 293);
            this.BottomLeftPic.Name = "BottomLeftPic";
            this.BottomLeftPic.Size = new System.Drawing.Size(246, 194);
            this.BottomLeftPic.TabIndex = 4;
            this.BottomLeftPic.TabStop = false;
            // 
            // BottomRightPic
            // 
            this.BottomRightPic.Location = new System.Drawing.Point(657, 293);
            this.BottomRightPic.Name = "BottomRightPic";
            this.BottomRightPic.Size = new System.Drawing.Size(246, 194);
            this.BottomRightPic.TabIndex = 5;
            this.BottomRightPic.TabStop = false;
            // 
            // AreYouLabel
            // 
            this.AreYouLabel.AutoSize = true;
            this.AreYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreYouLabel.Location = new System.Drawing.Point(167, 28);
            this.AreYouLabel.Name = "AreYouLabel";
            this.AreYouLabel.Size = new System.Drawing.Size(411, 76);
            this.AreYouLabel.TabIndex = 6;
            this.AreYouLabel.Text = "Are you a ....";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmailTB.Location = new System.Drawing.Point(217, 224);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(282, 26);
            this.EmailTB.TabIndex = 7;
            this.EmailTB.Text = "Enter your email";
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            this.EmailTB.Enter += new System.EventHandler(this.EmailTB_Enter);
            this.EmailTB.Leave += new System.EventHandler(this.EmailTB_Leave);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordTB.Location = new System.Drawing.Point(217, 279);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(282, 26);
            this.PasswordTB.TabIndex = 8;
            this.PasswordTB.Text = "Enter your Password";
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTB_Enter);
            this.PasswordTB.Leave += new System.EventHandler(this.PasswordTB_Leave);
            // 
            // ShowPasswordCB
            // 
            this.ShowPasswordCB.AutoSize = true;
            this.ShowPasswordCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCB.Location = new System.Drawing.Point(437, 314);
            this.ShowPasswordCB.Name = "ShowPasswordCB";
            this.ShowPasswordCB.Size = new System.Drawing.Size(164, 24);
            this.ShowPasswordCB.TabIndex = 10;
            this.ShowPasswordCB.Text = "Show Password";
            this.ShowPasswordCB.UseVisualStyleBackColor = true;
            this.ShowPasswordCB.CheckedChanged += new System.EventHandler(this.ShowPasswordCB_CheckedChanged);
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(199, 116);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(396, 75);
            this.groupBoxRadioButtons.TabIndex = 11;
            this.groupBoxRadioButtons.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "for testing chef";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.ShowPasswordCB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.AreYouLabel);
            this.Controls.Add(this.BottomRightPic);
            this.Controls.Add(this.BottomLeftPic);
            this.Controls.Add(this.TopLeftPic);
            this.Controls.Add(this.TopRightPic);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopRightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopRightPic;
        private System.Windows.Forms.PictureBox TopLeftPic;
        private System.Windows.Forms.PictureBox BottomLeftPic;
        private System.Windows.Forms.PictureBox BottomRightPic;
        private System.Windows.Forms.Label AreYouLabel;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.CheckBox ShowPasswordCB;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.Button button1;
    }
}