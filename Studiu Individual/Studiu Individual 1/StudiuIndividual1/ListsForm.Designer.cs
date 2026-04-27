namespace StudiuIndividual1
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            this.animalListButton = new System.Windows.Forms.Button();
            this.clientListButton = new System.Windows.Forms.Button();
            this.servicesListButton = new System.Windows.Forms.Button();
            this.campListButton = new System.Windows.Forms.Button();
            this.shopsListButton = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.backToHome = new System.Windows.Forms.Button();
            this.petShopDataSet = new StudiuIndividual1.PetShopDataSet();
            this.petShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new StudiuIndividual1.PetShopDataSetTableAdapters.AnimalTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petShopDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // animalListButton
            // 
            this.animalListButton.AutoSize = true;
            this.animalListButton.BackColor = System.Drawing.Color.Pink;
            this.animalListButton.Location = new System.Drawing.Point(30, 71);
            this.animalListButton.Name = "animalListButton";
            this.animalListButton.Padding = new System.Windows.Forms.Padding(3);
            this.animalListButton.Size = new System.Drawing.Size(180, 32);
            this.animalListButton.TabIndex = 1;
            this.animalListButton.Text = "Lista animalelor";
            this.animalListButton.UseVisualStyleBackColor = false;
            this.animalListButton.Click += new System.EventHandler(this.animalListButton_Click);
            // 
            // clientListButton
            // 
            this.clientListButton.AutoSize = true;
            this.clientListButton.BackColor = System.Drawing.Color.Pink;
            this.clientListButton.Location = new System.Drawing.Point(30, 119);
            this.clientListButton.Name = "clientListButton";
            this.clientListButton.Padding = new System.Windows.Forms.Padding(3);
            this.clientListButton.Size = new System.Drawing.Size(180, 32);
            this.clientListButton.TabIndex = 2;
            this.clientListButton.Text = "Lista clienților";
            this.clientListButton.UseVisualStyleBackColor = false;
            this.clientListButton.Click += new System.EventHandler(this.clientListButton_Click);
            // 
            // servicesListButton
            // 
            this.servicesListButton.AutoSize = true;
            this.servicesListButton.BackColor = System.Drawing.Color.Pink;
            this.servicesListButton.Location = new System.Drawing.Point(30, 176);
            this.servicesListButton.Name = "servicesListButton";
            this.servicesListButton.Padding = new System.Windows.Forms.Padding(3);
            this.servicesListButton.Size = new System.Drawing.Size(180, 32);
            this.servicesListButton.TabIndex = 3;
            this.servicesListButton.Text = "Lista serviciilor";
            this.servicesListButton.UseVisualStyleBackColor = false;
            this.servicesListButton.Click += new System.EventHandler(this.servicesListButton_Click);
            // 
            // campListButton
            // 
            this.campListButton.AutoSize = true;
            this.campListButton.BackColor = System.Drawing.Color.Pink;
            this.campListButton.Location = new System.Drawing.Point(29, 235);
            this.campListButton.Name = "campListButton";
            this.campListButton.Padding = new System.Windows.Forms.Padding(3);
            this.campListButton.Size = new System.Drawing.Size(180, 32);
            this.campListButton.TabIndex = 4;
            this.campListButton.Text = "Lista taberelor de zi";
            this.campListButton.UseVisualStyleBackColor = false;
            this.campListButton.Click += new System.EventHandler(this.campListButton_Click);
            // 
            // shopsListButton
            // 
            this.shopsListButton.AutoSize = true;
            this.shopsListButton.BackColor = System.Drawing.Color.Pink;
            this.shopsListButton.Location = new System.Drawing.Point(29, 293);
            this.shopsListButton.Name = "shopsListButton";
            this.shopsListButton.Padding = new System.Windows.Forms.Padding(3);
            this.shopsListButton.Size = new System.Drawing.Size(180, 32);
            this.shopsListButton.TabIndex = 5;
            this.shopsListButton.Text = "Lista tuturor magazinelor";
            this.shopsListButton.UseVisualStyleBackColor = false;
            this.shopsListButton.Click += new System.EventHandler(this.shopsListButton_Click);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoText.ForeColor = System.Drawing.Color.Maroon;
            this.infoText.Location = new System.Drawing.Point(28, 22);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(156, 20);
            this.infoText.TabIndex = 6;
            this.infoText.Text = "Alegeți lista căutată";
            this.infoText.Click += new System.EventHandler(this.infoText_Click);
            // 
            // backToHome
            // 
            this.backToHome.AutoSize = true;
            this.backToHome.Location = new System.Drawing.Point(32, 400);
            this.backToHome.Name = "backToHome";
            this.backToHome.Padding = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.backToHome.Size = new System.Drawing.Size(123, 32);
            this.backToHome.TabIndex = 7;
            this.backToHome.Text = "Înapoi la home";
            this.backToHome.UseVisualStyleBackColor = true;
            this.backToHome.Click += new System.EventHandler(this.backToHome_Click);
            // 
            // petShopDataSet
            // 
            this.petShopDataSet.DataSetName = "PetShopDataSet";
            this.petShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petShopDataSetBindingSource
            // 
            this.petShopDataSetBindingSource.DataSource = this.petShopDataSet;
            this.petShopDataSetBindingSource.Position = 0;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.petShopDataSetBindingSource;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 410);
            this.dataGridView1.TabIndex = 8;
            // 
            // petShopDataSetBindingSource1
            // 
            this.petShopDataSetBindingSource1.DataSource = this.petShopDataSet;
            this.petShopDataSetBindingSource1.Position = 0;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.shopsListButton);
            this.Controls.Add(this.campListButton);
            this.Controls.Add(this.servicesListButton);
            this.Controls.Add(this.clientListButton);
            this.Controls.Add(this.animalListButton);
            this.Name = "ViewForm";
            this.Text = "View Form";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button animalListButton;
        private System.Windows.Forms.Button clientListButton;
        private System.Windows.Forms.Button servicesListButton;
        private System.Windows.Forms.Button campListButton;
        private System.Windows.Forms.Button shopsListButton;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.BindingSource petShopDataSetBindingSource;
        private PetShopDataSet petShopDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private PetShopDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource petShopDataSetBindingSource1;
    }
}