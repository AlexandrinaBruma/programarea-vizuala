namespace StudiuIndividual1
{
    partial class AnimalForm
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
            this.introText = new System.Windows.Forms.Label();
            this.backToHome = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.intollerancesTextBox = new System.Windows.Forms.TextBox();
            this.speciesTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birthBox = new System.Windows.Forms.DateTimePicker();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introText
            // 
            this.introText.AutoSize = true;
            this.introText.BackColor = System.Drawing.Color.Transparent;
            this.introText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.introText.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.introText.Location = new System.Drawing.Point(151, 41);
            this.introText.Name = "introText";
            this.introText.Size = new System.Drawing.Size(467, 20);
            this.introText.TabIndex = 0;
            this.introText.Text = "INTRODUCETI DATELE ANIMALULUI DE COMPANIE:";
            this.introText.Click += new System.EventHandler(this.introText_Click);
            // 
            // backToHome
            // 
            this.backToHome.AutoSize = true;
            this.backToHome.Location = new System.Drawing.Point(495, 382);
            this.backToHome.Name = "backToHome";
            this.backToHome.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.backToHome.Size = new System.Drawing.Size(123, 32);
            this.backToHome.TabIndex = 8;
            this.backToHome.Text = "Înapoi la home";
            this.backToHome.UseVisualStyleBackColor = true;
            this.backToHome.Click += new System.EventHandler(this.backToHome_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Pink;
            this.addButton.Location = new System.Drawing.Point(137, 382);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(3);
            this.addButton.Size = new System.Drawing.Size(180, 32);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Adaugă animalul!";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ownerTextBox.Location = new System.Drawing.Point(137, 262);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(200, 22);
            this.ownerTextBox.TabIndex = 12;
            this.ownerTextBox.Text = "Introduceți ID-ul stăpânului...";
            // 
            // intollerancesTextBox
            // 
            this.intollerancesTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.intollerancesTextBox.Location = new System.Drawing.Point(418, 181);
            this.intollerancesTextBox.Name = "intollerancesTextBox";
            this.intollerancesTextBox.Size = new System.Drawing.Size(200, 22);
            this.intollerancesTextBox.TabIndex = 11;
            this.intollerancesTextBox.Text = "Introduceți contraindicațiile...";
            // 
            // speciesTextBox
            // 
            this.speciesTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.speciesTextBox.Location = new System.Drawing.Point(137, 181);
            this.speciesTextBox.Name = "speciesTextBox";
            this.speciesTextBox.Size = new System.Drawing.Size(200, 22);
            this.speciesTextBox.TabIndex = 10;
            this.speciesTextBox.Text = "Introduceți specia...";
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nameTextBox.Location = new System.Drawing.Point(137, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Text = "Introduceți numele...";
            // 
            // birthBox
            // 
            this.birthBox.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.birthBox.CalendarTitleForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.birthBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthBox.Location = new System.Drawing.Point(418, 101);
            this.birthBox.MaxDate = new System.DateTime(2026, 2, 28, 0, 0, 0, 0);
            this.birthBox.Name = "birthBox";
            this.birthBox.Size = new System.Drawing.Size(200, 22);
            this.birthBox.TabIndex = 14;
            this.birthBox.TabStop = false;
            this.birthBox.Value = new System.DateTime(2026, 2, 28, 0, 0, 0, 0);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(317, 308);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 26;
            this.statusLabel.Visible = false;
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(this.intollerancesTextBox);
            this.Controls.Add(this.speciesTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.birthBox);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.introText);
            this.Name = "AnimalForm";
            this.Text = "Animal Form";
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introText;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox intollerancesTextBox;
        private System.Windows.Forms.TextBox speciesTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker birthBox;
        private System.Windows.Forms.Label statusLabel;
    }
}