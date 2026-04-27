namespace StudiuIndividual1
{
    partial class homeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.addAnimalButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.signUpButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addServiceButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addAnimalButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.closeButton, 2);
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Location = new System.Drawing.Point(3, 359);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(728, 35);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Închidere";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Pink;
            this.signUpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpButton.Location = new System.Drawing.Point(370, 181);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(361, 172);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Înscrieți-vă ca client nou";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.BackColor = System.Drawing.Color.Pink;
            this.addServiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addServiceButton.Location = new System.Drawing.Point(3, 181);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(361, 172);
            this.addServiceButton.TabIndex = 2;
            this.addServiceButton.Text = "Înscrieți-vă animalul la un serviciu";
            this.addServiceButton.UseVisualStyleBackColor = false;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // addAnimalButton
            // 
            this.addAnimalButton.BackColor = System.Drawing.Color.Pink;
            this.addAnimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAnimalButton.Location = new System.Drawing.Point(370, 3);
            this.addAnimalButton.Name = "addAnimalButton";
            this.addAnimalButton.Size = new System.Drawing.Size(361, 172);
            this.addAnimalButton.TabIndex = 1;
            this.addAnimalButton.Text = "Adăugați un nou animal";
            this.addAnimalButton.UseVisualStyleBackColor = false;
            this.addAnimalButton.Click += new System.EventHandler(this.addAnimal_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.Pink;
            this.viewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewButton.Location = new System.Drawing.Point(3, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(361, 172);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "Vizualizarea tuturor listelor";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "homeForm";
            this.Text = "Home Form";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button addAnimalButton;
        private System.Windows.Forms.Button closeButton;
    }
}