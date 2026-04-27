namespace StudiuIndividual1
{
    partial class CampForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.petTextBox = new System.Windows.Forms.TextBox();
            this.backToHome = new System.Windows.Forms.Button();
            this.introText = new System.Windows.Forms.Label();
            this.campIDTextBox = new System.Windows.Forms.TextBox();
            this.overNightCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hour2 = new System.Windows.Forms.DateTimePicker();
            this.hour1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(298, 313);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 35;
            this.statusLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Thistle;
            this.addButton.Location = new System.Drawing.Point(160, 380);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(3);
            this.addButton.Size = new System.Drawing.Size(180, 32);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "Înscrie!";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // petTextBox
            // 
            this.petTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.petTextBox.Location = new System.Drawing.Point(160, 99);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.Size = new System.Drawing.Size(200, 22);
            this.petTextBox.TabIndex = 28;
            this.petTextBox.Text = "Introduceți ID-ul animalului...";
            // 
            // backToHome
            // 
            this.backToHome.AutoSize = true;
            this.backToHome.Location = new System.Drawing.Point(518, 380);
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
            this.introText.ForeColor = System.Drawing.Color.Purple;
            this.introText.Location = new System.Drawing.Point(223, 39);
            this.introText.Name = "introText";
            this.introText.Size = new System.Drawing.Size(330, 20);
            this.introText.TabIndex = 26;
            this.introText.Text = "INTRODUCETI DATELE REZERVĂRII:";
            // 
            // campIDTextBox
            // 
            this.campIDTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.campIDTextBox.Location = new System.Drawing.Point(160, 179);
            this.campIDTextBox.Name = "campIDTextBox";
            this.campIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.campIDTextBox.TabIndex = 36;
            this.campIDTextBox.Text = "Introduceți ID-ul taberei...";
            // 
            // overNightCheckBox
            // 
            this.overNightCheckBox.AutoSize = true;
            this.overNightCheckBox.Location = new System.Drawing.Point(441, 260);
            this.overNightCheckBox.Name = "overNightCheckBox";
            this.overNightCheckBox.Size = new System.Drawing.Size(156, 20);
            this.overNightCheckBox.TabIndex = 38;
            this.overNightCheckBox.Text = "Ședere peste noapte";
            this.overNightCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(160, 258);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 39;
            // 
            // hour2
            // 
            this.hour2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hour2.Location = new System.Drawing.Point(441, 179);
            this.hour2.Name = "hour2";
            this.hour2.Size = new System.Drawing.Size(200, 22);
            this.hour2.TabIndex = 41;
            // 
            // hour1
            // 
            this.hour1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hour1.Location = new System.Drawing.Point(441, 99);
            this.hour1.Name = "hour1";
            this.hour1.Size = new System.Drawing.Size(200, 22);
            this.hour1.TabIndex = 40;
            // 
            // CampForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hour2);
            this.Controls.Add(this.hour1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.overNightCheckBox);
            this.Controls.Add(this.campIDTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.petTextBox);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.introText);
            this.Name = "CampForm";
            this.Text = "Camp Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox petTextBox;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Label introText;
        private System.Windows.Forms.TextBox campIDTextBox;
        private System.Windows.Forms.CheckBox overNightCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker hour2;
        private System.Windows.Forms.DateTimePicker hour1;
    }
}