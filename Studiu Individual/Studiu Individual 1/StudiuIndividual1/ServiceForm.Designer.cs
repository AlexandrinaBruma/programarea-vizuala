namespace StudiuIndividual1
{
    partial class AppointmentForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.backToHome = new System.Windows.Forms.Button();
            this.introText = new System.Windows.Forms.Label();
            this.enrollToCampButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.hour1 = new System.Windows.Forms.DateTimePicker();
            this.hour2 = new System.Windows.Forms.DateTimePicker();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Thistle;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(370, 380);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(3);
            this.addButton.Size = new System.Drawing.Size(138, 32);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Înscrie!";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ownerIDTextBox.Location = new System.Drawing.Point(160, 260);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.ownerIDTextBox.TabIndex = 20;
            this.ownerIDTextBox.Text = "Introduceți ID-ul clientului...";
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.petNameTextBox.Location = new System.Drawing.Point(160, 179);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.petNameTextBox.TabIndex = 18;
            this.petNameTextBox.Text = "Introduceți ID-ul animalului...";
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.serviceTextBox.Location = new System.Drawing.Point(160, 99);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(200, 22);
            this.serviceTextBox.TabIndex = 17;
            this.serviceTextBox.Text = "Introduceți serviciul...";
            // 
            // backToHome
            // 
            this.backToHome.AutoSize = true;
            this.backToHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.backToHome.Location = new System.Drawing.Point(518, 380);
            this.backToHome.Name = "backToHome";
            this.backToHome.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.backToHome.Size = new System.Drawing.Size(123, 32);
            this.backToHome.TabIndex = 16;
            this.backToHome.Text = "Înapoi la home";
            this.backToHome.UseVisualStyleBackColor = false;
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
            this.introText.TabIndex = 15;
            this.introText.Text = "INTRODUCETI DATELE REZERVĂRII:";
            // 
            // enrollToCampButton
            // 
            this.enrollToCampButton.AutoSize = true;
            this.enrollToCampButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enrollToCampButton.Location = new System.Drawing.Point(160, 380);
            this.enrollToCampButton.Name = "enrollToCampButton";
            this.enrollToCampButton.Padding = new System.Windows.Forms.Padding(3);
            this.enrollToCampButton.Size = new System.Drawing.Size(200, 32);
            this.enrollToCampButton.TabIndex = 24;
            this.enrollToCampButton.Text = "Înscrieți-vă la tavăra de zi";
            this.enrollToCampButton.UseVisualStyleBackColor = false;
            this.enrollToCampButton.Click += new System.EventHandler(this.enrollToCampButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(298, 313);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 25;
            this.statusLabel.Visible = false;
            // 
            // hour1
            // 
            this.hour1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hour1.Location = new System.Drawing.Point(441, 99);
            this.hour1.Name = "hour1";
            this.hour1.Size = new System.Drawing.Size(200, 22);
            this.hour1.TabIndex = 26;
            // 
            // hour2
            // 
            this.hour2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hour2.Location = new System.Drawing.Point(441, 179);
            this.hour2.Name = "hour2";
            this.hour2.Size = new System.Drawing.Size(200, 22);
            this.hour2.TabIndex = 27;
            // 
            // dateBox
            // 
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBox.Location = new System.Drawing.Point(441, 258);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 22);
            this.dateBox.TabIndex = 28;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.hour2);
            this.Controls.Add(this.hour1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.enrollToCampButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ownerIDTextBox);
            this.Controls.Add(this.petNameTextBox);
            this.Controls.Add(this.serviceTextBox);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.introText);
            this.Name = "AppointmentForm";
            this.Text = "Appointment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ownerIDTextBox;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Label introText;
        private System.Windows.Forms.Button enrollToCampButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DateTimePicker hour1;
        private System.Windows.Forms.DateTimePicker hour2;
        private System.Windows.Forms.DateTimePicker dateBox;
    }
}