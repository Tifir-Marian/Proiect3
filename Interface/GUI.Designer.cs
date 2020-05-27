namespace Interface
{
    partial class GUI
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.PathString = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationString = new System.Windows.Forms.TextBox();
            this.TypeOfPhotoLabel = new System.Windows.Forms.Label();
            this.TypeOfPhotoString = new System.Windows.Forms.TextBox();
            this.CreatinoDateLabel = new System.Windows.Forms.Label();
            this.CreationDateString = new System.Windows.Forms.TextBox();
            this.AddToButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameString = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(198, 55);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(77, 24);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PathString
            // 
            this.PathString.Location = new System.Drawing.Point(25, 55);
            this.PathString.Name = "PathString";
            this.PathString.Size = new System.Drawing.Size(167, 20);
            this.PathString.TabIndex = 1;
            this.PathString.TextChanged += new System.EventHandler(this.PathString_TextChanged);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(22, 39);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(29, 13);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.Text = "Path";
            this.PathLabel.Click += new System.EventHandler(this.PathLabel_Click);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(22, 88);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 3;
            this.LocationLabel.Text = "Location";
            this.LocationLabel.Click += new System.EventHandler(this.LocationLabel_Click);
            // 
            // LocationString
            // 
            this.LocationString.Location = new System.Drawing.Point(25, 104);
            this.LocationString.Name = "LocationString";
            this.LocationString.Size = new System.Drawing.Size(167, 20);
            this.LocationString.TabIndex = 4;
            this.LocationString.TextChanged += new System.EventHandler(this.LocationString_TextChanged);
            // 
            // TypeOfPhotoLabel
            // 
            this.TypeOfPhotoLabel.AutoSize = true;
            this.TypeOfPhotoLabel.Location = new System.Drawing.Point(22, 136);
            this.TypeOfPhotoLabel.Name = "TypeOfPhotoLabel";
            this.TypeOfPhotoLabel.Size = new System.Drawing.Size(70, 13);
            this.TypeOfPhotoLabel.TabIndex = 5;
            this.TypeOfPhotoLabel.Text = "TypeOfPhoto";
            this.TypeOfPhotoLabel.Click += new System.EventHandler(this.TypeOfPhotoLabel_Click);
            // 
            // TypeOfPhotoString
            // 
            this.TypeOfPhotoString.Location = new System.Drawing.Point(25, 152);
            this.TypeOfPhotoString.Name = "TypeOfPhotoString";
            this.TypeOfPhotoString.Size = new System.Drawing.Size(167, 20);
            this.TypeOfPhotoString.TabIndex = 6;
            this.TypeOfPhotoString.TextChanged += new System.EventHandler(this.TypeOfPhotoString_TextChanged);
            // 
            // CreatinoDateLabel
            // 
            this.CreatinoDateLabel.AutoSize = true;
            this.CreatinoDateLabel.Location = new System.Drawing.Point(23, 192);
            this.CreatinoDateLabel.Name = "CreatinoDateLabel";
            this.CreatinoDateLabel.Size = new System.Drawing.Size(69, 13);
            this.CreatinoDateLabel.TabIndex = 7;
            this.CreatinoDateLabel.Text = "CreatinoDate";
            this.CreatinoDateLabel.Click += new System.EventHandler(this.CreatinoDateLabel_Click);
            // 
            // CreationDateString
            // 
            this.CreationDateString.Location = new System.Drawing.Point(25, 208);
            this.CreationDateString.Name = "CreationDateString";
            this.CreationDateString.Size = new System.Drawing.Size(167, 20);
            this.CreationDateString.TabIndex = 8;
            this.CreationDateString.TextChanged += new System.EventHandler(this.CreationDateString_TextChanged);
            // 
            // AddToButton
            // 
            this.AddToButton.Location = new System.Drawing.Point(105, 302);
            this.AddToButton.Name = "AddToButton";
            this.AddToButton.Size = new System.Drawing.Size(87, 27);
            this.AddToButton.TabIndex = 9;
            this.AddToButton.Text = "AddTo";
            this.AddToButton.UseVisualStyleBackColor = true;
            this.AddToButton.Click += new System.EventHandler(this.AddToButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(2, 301);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(81, 28);
            this.InsertButton.TabIndex = 10;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(25, 234);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name";
            // 
            // NameString
            // 
            this.NameString.Location = new System.Drawing.Point(26, 258);
            this.NameString.Name = "NameString";
            this.NameString.Size = new System.Drawing.Size(165, 20);
            this.NameString.TabIndex = 12;
            this.NameString.TextChanged += new System.EventHandler(this.NameString_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameString);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AddToButton);
            this.Controls.Add(this.CreationDateString);
            this.Controls.Add(this.CreatinoDateLabel);
            this.Controls.Add(this.TypeOfPhotoString);
            this.Controls.Add(this.TypeOfPhotoLabel);
            this.Controls.Add(this.LocationString);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathString);
            this.Controls.Add(this.SearchButton);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox PathString;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox LocationString;
        private System.Windows.Forms.Label TypeOfPhotoLabel;
        private System.Windows.Forms.TextBox TypeOfPhotoString;
        private System.Windows.Forms.Label CreatinoDateLabel;
        private System.Windows.Forms.TextBox CreationDateString;
        private System.Windows.Forms.Button AddToButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameString;
        private System.Windows.Forms.Button button1;
    }
}