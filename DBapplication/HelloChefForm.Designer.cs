namespace DBapplication
{
    partial class HelloChefForm
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
            this.AddRecipe = new System.Windows.Forms.Button();
            this.EditRecipe = new System.Windows.Forms.Button();
            this.DeleteRecipe = new System.Windows.Forms.Button();
            this.mainpicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRecipe
            // 
            this.AddRecipe.Location = new System.Drawing.Point(12, 184);
            this.AddRecipe.Name = "AddRecipe";
            this.AddRecipe.Size = new System.Drawing.Size(193, 93);
            this.AddRecipe.TabIndex = 0;
            this.AddRecipe.Text = "Share A New Recipe";
            this.AddRecipe.UseVisualStyleBackColor = true;
            this.AddRecipe.Click += new System.EventHandler(this.AddRecipe_Click);
            // 
            // EditRecipe
            // 
            this.EditRecipe.Location = new System.Drawing.Point(288, 184);
            this.EditRecipe.Name = "EditRecipe";
            this.EditRecipe.Size = new System.Drawing.Size(193, 93);
            this.EditRecipe.TabIndex = 1;
            this.EditRecipe.Text = "Edit An Existing Recipe";
            this.EditRecipe.UseVisualStyleBackColor = true;
            // 
            // DeleteRecipe
            // 
            this.DeleteRecipe.Location = new System.Drawing.Point(583, 184);
            this.DeleteRecipe.Name = "DeleteRecipe";
            this.DeleteRecipe.Size = new System.Drawing.Size(193, 93);
            this.DeleteRecipe.TabIndex = 2;
            this.DeleteRecipe.Text = "Remove A Recipe From Your Profile";
            this.DeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // mainpicture
            // 
            this.mainpicture.Location = new System.Drawing.Point(567, 21);
            this.mainpicture.Name = "mainpicture";
            this.mainpicture.Size = new System.Drawing.Size(209, 135);
            this.mainpicture.TabIndex = 3;
            this.mainpicture.TabStop = false;
            this.mainpicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello Chef...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "How Can I Help You";
            // 
            // HelloChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainpicture);
            this.Controls.Add(this.DeleteRecipe);
            this.Controls.Add(this.EditRecipe);
            this.Controls.Add(this.AddRecipe);
            this.Name = "HelloChefForm";
            this.Text = "HelloChefForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelloChefForm_FormClosed);
            this.Load += new System.EventHandler(this.HelloChef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRecipe;
        private System.Windows.Forms.Button EditRecipe;
        private System.Windows.Forms.Button DeleteRecipe;
        private System.Windows.Forms.PictureBox mainpicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}