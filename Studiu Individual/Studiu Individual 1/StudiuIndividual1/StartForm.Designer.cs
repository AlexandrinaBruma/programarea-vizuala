namespace StudiuIndividual1
{
    partial class StartForm
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
            this.WelcomeText = new System.Windows.Forms.Label();
            this.introText = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeText.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.WelcomeText.Location = new System.Drawing.Point(298, 141);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(234, 25);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "Bine ați venit la Pet Shop!";
            // 
            // introText
            // 
            this.introText.AutoSize = true;
            this.introText.Location = new System.Drawing.Point(311, 178);
            this.introText.Name = "introText";
            this.introText.Size = new System.Drawing.Size(200, 16);
            this.introText.TabIndex = 1;
            this.introText.Text = "Pentru a începe, apăsați butonul.";
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = true;
            this.homeButton.BackColor = System.Drawing.Color.Pink;
            this.homeButton.Location = new System.Drawing.Point(350, 213);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.homeButton.Size = new System.Drawing.Size(131, 32);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Mergeți la home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(350, 251);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.closeButton.Size = new System.Drawing.Size(131, 32);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Închidere";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeHome_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.introText);
            this.Controls.Add(this.WelcomeText);
            this.IsMdiContainer = true;
            this.Name = "StartForm";
            this.Text = "Start Form";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Label introText;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button closeButton;
    }
}

