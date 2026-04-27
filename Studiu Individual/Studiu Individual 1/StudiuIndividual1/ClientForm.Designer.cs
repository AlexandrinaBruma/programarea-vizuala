namespace StudiuIndividual1
{
    partial class ClientForm
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.enrollButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.backToHome = new System.Windows.Forms.Button();
            this.introText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(249, 313);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 35;
            this.statusLabel.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emailTextBox.Location = new System.Drawing.Point(430, 179);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 22);
            this.emailTextBox.TabIndex = 33;
            this.emailTextBox.Text = "Introduceți adresa de email...";
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nameTextBox.Location = new System.Drawing.Point(430, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 22);
            this.nameTextBox.TabIndex = 32;
            this.nameTextBox.Text = "Introduceți prenumele...";
            // 
            // enrollButton
            // 
            this.enrollButton.AutoSize = true;
            this.enrollButton.BackColor = System.Drawing.Color.LightCoral;
            this.enrollButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enrollButton.Location = new System.Drawing.Point(100, 380);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Padding = new System.Windows.Forms.Padding(3);
            this.enrollButton.Size = new System.Drawing.Size(180, 32);
            this.enrollButton.TabIndex = 31;
            this.enrollButton.Text = "Înregistrare!";
            this.enrollButton.UseVisualStyleBackColor = false;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.addressTextBox.Location = new System.Drawing.Point(100, 260);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(250, 22);
            this.addressTextBox.TabIndex = 30;
            this.addressTextBox.Text = "Introduceți adresa de reședintă...";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(100, 179);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(250, 22);
            this.phoneNumberTextBox.TabIndex = 29;
            this.phoneNumberTextBox.Text = "Introduceți numărul de telefon...";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.surnameTextBox.Location = new System.Drawing.Point(100, 99);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(250, 22);
            this.surnameTextBox.TabIndex = 28;
            this.surnameTextBox.Text = "Introduceți numele...";
            // 
            // backToHome
            // 
            this.backToHome.AutoSize = true;
            this.backToHome.Location = new System.Drawing.Point(557, 380);
            this.backToHome.Name = "backToHome";
            this.backToHome.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.backToHome.Size = new System.Drawing.Size(123, 32);
            this.backToHome.TabIndex = 27;
            this.backToHome.Text = "Înapoi la home";
            this.backToHome.UseVisualStyleBackColor = true;
            this.backToHome.Click += new System.EventHandler(this.backToHome_Click);
            // 
            // introText
            // 
            this.introText.AutoSize = true;
            this.introText.BackColor = System.Drawing.Color.Transparent;
            this.introText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.introText.ForeColor = System.Drawing.Color.IndianRed;
            this.introText.Location = new System.Drawing.Point(302, 39);
            this.introText.Name = "introText";
            this.introText.Size = new System.Drawing.Size(166, 20);
            this.introText.TabIndex = 26;
            this.introText.Text = "ÎNREGISTRAȚI-VĂ";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.introText);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Label introText;
    }
}