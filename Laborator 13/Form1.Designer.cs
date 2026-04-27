namespace Laborator_13
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.studentPage = new System.Windows.Forms.TabPage();
            this.profesorPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.obiectPage = new System.Windows.Forms.TabPage();
            this.orarPage = new System.Windows.Forms.TabPage();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.patronimicLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.groupIDlabel = new System.Windows.Forms.Label();
            this.hometownLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.homeTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronimicTextBox = new System.Windows.Forms.TextBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.modityButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.studentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.studentPage);
            this.TabControl.Controls.Add(this.profesorPage);
            this.TabControl.Controls.Add(this.obiectPage);
            this.TabControl.Controls.Add(this.orarPage);
            this.TabControl.Location = new System.Drawing.Point(12, 34);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(776, 360);
            this.TabControl.TabIndex = 0;
            // 
            // studentPage
            // 
            this.studentPage.Controls.Add(this.deleteButton);
            this.studentPage.Controls.Add(this.modityButton);
            this.studentPage.Controls.Add(this.saveButton);
            this.studentPage.Controls.Add(this.addButton);
            this.studentPage.Controls.Add(this.dateTimePicker1);
            this.studentPage.Controls.Add(this.genderComboBox);
            this.studentPage.Controls.Add(this.groupComboBox);
            this.studentPage.Controls.Add(this.patronimicTextBox);
            this.studentPage.Controls.Add(this.surnameTextBox);
            this.studentPage.Controls.Add(this.homeTextBox);
            this.studentPage.Controls.Add(this.phoneTextBox);
            this.studentPage.Controls.Add(this.nameTextBox);
            this.studentPage.Controls.Add(this.hometownLabel);
            this.studentPage.Controls.Add(this.groupIDlabel);
            this.studentPage.Controls.Add(this.phoneNumLabel);
            this.studentPage.Controls.Add(this.birthdateLabel);
            this.studentPage.Controls.Add(this.genderLabel);
            this.studentPage.Controls.Add(this.patronimicLabel);
            this.studentPage.Controls.Add(this.surnameLabel);
            this.studentPage.Controls.Add(this.nameLabel);
            this.studentPage.Location = new System.Drawing.Point(4, 25);
            this.studentPage.Name = "studentPage";
            this.studentPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentPage.Size = new System.Drawing.Size(768, 331);
            this.studentPage.TabIndex = 0;
            this.studentPage.Text = "Student";
            this.studentPage.UseVisualStyleBackColor = true;
            // 
            // profesorPage
            // 
            this.profesorPage.Location = new System.Drawing.Point(4, 25);
            this.profesorPage.Name = "profesorPage";
            this.profesorPage.Padding = new System.Windows.Forms.Padding(3);
            this.profesorPage.Size = new System.Drawing.Size(768, 331);
            this.profesorPage.TabIndex = 1;
            this.profesorPage.Text = "Profesor";
            this.profesorPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // obiectPage
            // 
            this.obiectPage.Location = new System.Drawing.Point(4, 25);
            this.obiectPage.Name = "obiectPage";
            this.obiectPage.Padding = new System.Windows.Forms.Padding(3);
            this.obiectPage.Size = new System.Drawing.Size(768, 331);
            this.obiectPage.TabIndex = 2;
            this.obiectPage.Text = "Obiect";
            this.obiectPage.UseVisualStyleBackColor = true;
            // 
            // orarPage
            // 
            this.orarPage.Location = new System.Drawing.Point(4, 25);
            this.orarPage.Name = "orarPage";
            this.orarPage.Padding = new System.Windows.Forms.Padding(3);
            this.orarPage.Size = new System.Drawing.Size(768, 331);
            this.orarPage.TabIndex = 3;
            this.orarPage.Text = "Orar";
            this.orarPage.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(20, 68);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(61, 16);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Prenume";
            this.surnameLabel.Click += new System.EventHandler(this.surnameLabel_Click);
            // 
            // patronimicLabel
            // 
            this.patronimicLabel.AutoSize = true;
            this.patronimicLabel.Location = new System.Drawing.Point(20, 102);
            this.patronimicLabel.Name = "patronimicLabel";
            this.patronimicLabel.Size = new System.Drawing.Size(70, 16);
            this.patronimicLabel.TabIndex = 2;
            this.patronimicLabel.Text = "Patronimic";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(20, 138);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 16);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Genul";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(21, 173);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(82, 16);
            this.birthdateLabel.TabIndex = 4;
            this.birthdateLabel.Text = "Data nasterii";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(21, 210);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(109, 16);
            this.phoneNumLabel.TabIndex = 5;
            this.phoneNumLabel.Text = "Numar de telefon";
            // 
            // groupIDlabel
            // 
            this.groupIDlabel.AutoSize = true;
            this.groupIDlabel.Location = new System.Drawing.Point(21, 247);
            this.groupIDlabel.Name = "groupIDlabel";
            this.groupIDlabel.Size = new System.Drawing.Size(75, 16);
            this.groupIDlabel.TabIndex = 6;
            this.groupIDlabel.Text = "ID-ul grupei";
            // 
            // hometownLabel
            // 
            this.hometownLabel.AutoSize = true;
            this.hometownLabel.Location = new System.Drawing.Point(21, 285);
            this.hometownLabel.Name = "hometownLabel";
            this.hometownLabel.Size = new System.Drawing.Size(89, 16);
            this.hometownLabel.TabIndex = 7;
            this.hometownLabel.Text = "ID-ul localității";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(179, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(179, 204);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 9;
            // 
            // homeTextBox
            // 
            this.homeTextBox.Location = new System.Drawing.Point(179, 279);
            this.homeTextBox.Name = "homeTextBox";
            this.homeTextBox.Size = new System.Drawing.Size(200, 22);
            this.homeTextBox.TabIndex = 10;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(179, 62);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.surnameTextBox.TabIndex = 11;
            // 
            // patronimicTextBox
            // 
            this.patronimicTextBox.Location = new System.Drawing.Point(179, 96);
            this.patronimicTextBox.Name = "patronimicTextBox";
            this.patronimicTextBox.Size = new System.Drawing.Size(200, 22);
            this.patronimicTextBox.TabIndex = 12;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(179, 239);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(200, 24);
            this.groupComboBox.TabIndex = 13;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(179, 130);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 24);
            this.genderComboBox.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.HotPink;
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(525, 27);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(10);
            this.addButton.Size = new System.Drawing.Size(208, 46);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Adaugă";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.Color.DeepPink;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(525, 104);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(10);
            this.saveButton.Size = new System.Drawing.Size(208, 46);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Salvează";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // modityButton
            // 
            this.modityButton.AutoSize = true;
            this.modityButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.modityButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modityButton.Location = new System.Drawing.Point(525, 180);
            this.modityButton.Name = "modityButton";
            this.modityButton.Padding = new System.Windows.Forms.Padding(10);
            this.modityButton.Size = new System.Drawing.Size(208, 46);
            this.modityButton.TabIndex = 18;
            this.modityButton.Text = "Modifică";
            this.modityButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.BackColor = System.Drawing.Color.Orchid;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(525, 255);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(10);
            this.deleteButton.Size = new System.Drawing.Size(208, 46);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Șterge";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.studentPage.ResumeLayout(false);
            this.studentPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage studentPage;
        private System.Windows.Forms.TabPage profesorPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage obiectPage;
        private System.Windows.Forms.TabPage orarPage;
        private System.Windows.Forms.Label hometownLabel;
        private System.Windows.Forms.Label groupIDlabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label patronimicLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.TextBox patronimicTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox homeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modityButton;
        private System.Windows.Forms.Button saveButton;
    }
}

