namespace BasketUI
{
    partial class BasketForm
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
            this.ButterButton = new System.Windows.Forms.Button();
            this.MilkButton = new System.Windows.Forms.Button();
            this.BreadButton = new System.Windows.Forms.Button();
            this.ButterTextBox = new System.Windows.Forms.TextBox();
            this.MilkTextBox = new System.Windows.Forms.TextBox();
            this.BreadTextBox = new System.Windows.Forms.TextBox();
            this.OffersTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButterButton
            // 
            this.ButterButton.Location = new System.Drawing.Point(37, 42);
            this.ButterButton.Name = "ButterButton";
            this.ButterButton.Size = new System.Drawing.Size(75, 23);
            this.ButterButton.TabIndex = 0;
            this.ButterButton.Text = "Butter";
            this.ButterButton.UseVisualStyleBackColor = true;
            this.ButterButton.Click += new System.EventHandler(this.ButterButton_Click);
            // 
            // MilkButton
            // 
            this.MilkButton.Location = new System.Drawing.Point(37, 72);
            this.MilkButton.Name = "MilkButton";
            this.MilkButton.Size = new System.Drawing.Size(75, 23);
            this.MilkButton.TabIndex = 1;
            this.MilkButton.Text = "Milk";
            this.MilkButton.UseVisualStyleBackColor = true;
            // 
            // BreadButton
            // 
            this.BreadButton.Location = new System.Drawing.Point(37, 102);
            this.BreadButton.Name = "BreadButton";
            this.BreadButton.Size = new System.Drawing.Size(75, 23);
            this.BreadButton.TabIndex = 2;
            this.BreadButton.Text = "Bread";
            this.BreadButton.UseVisualStyleBackColor = true;
            // 
            // ButterTextBox
            // 
            this.ButterTextBox.Location = new System.Drawing.Point(144, 42);
            this.ButterTextBox.Name = "ButterTextBox";
            this.ButterTextBox.ReadOnly = true;
            this.ButterTextBox.Size = new System.Drawing.Size(100, 20);
            this.ButterTextBox.TabIndex = 3;
            this.ButterTextBox.Text = "£0.80";
            // 
            // MilkTextBox
            // 
            this.MilkTextBox.Location = new System.Drawing.Point(144, 70);
            this.MilkTextBox.Name = "MilkTextBox";
            this.MilkTextBox.ReadOnly = true;
            this.MilkTextBox.Size = new System.Drawing.Size(100, 20);
            this.MilkTextBox.TabIndex = 4;
            this.MilkTextBox.Text = "£1.15";
            // 
            // BreadTextBox
            // 
            this.BreadTextBox.Location = new System.Drawing.Point(144, 104);
            this.BreadTextBox.Name = "BreadTextBox";
            this.BreadTextBox.ReadOnly = true;
            this.BreadTextBox.Size = new System.Drawing.Size(100, 20);
            this.BreadTextBox.TabIndex = 5;
            this.BreadTextBox.Text = "£1.00";
            // 
            // OffersTextBox
            // 
            this.OffersTextBox.Location = new System.Drawing.Point(37, 151);
            this.OffersTextBox.Multiline = true;
            this.OffersTextBox.Name = "OffersTextBox";
            this.OffersTextBox.ReadOnly = true;
            this.OffersTextBox.Size = new System.Drawing.Size(207, 40);
            this.OffersTextBox.TabIndex = 6;
            this.OffersTextBox.Text = "Buy 2 Butter and get a Bread at 50% off\r\nBuy 3 Milk and get the 4th milk for free" +
    "\r\n";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(81, 213);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(144, 213);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 8;
            this.TotalTextBox.Text = "£0.00";
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.OffersTextBox);
            this.Controls.Add(this.BreadTextBox);
            this.Controls.Add(this.MilkTextBox);
            this.Controls.Add(this.ButterTextBox);
            this.Controls.Add(this.BreadButton);
            this.Controls.Add(this.MilkButton);
            this.Controls.Add(this.ButterButton);
            this.Name = "BasketForm";
            this.Text = "BasketApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButterButton;
        public System.Windows.Forms.Button MilkButton;
        public System.Windows.Forms.Button BreadButton;
        public System.Windows.Forms.TextBox ButterTextBox;
        public System.Windows.Forms.TextBox MilkTextBox;
        public System.Windows.Forms.TextBox BreadTextBox;
        public System.Windows.Forms.TextBox OffersTextBox;
        public System.Windows.Forms.Label TotalLabel;
        public System.Windows.Forms.TextBox TotalTextBox;
    }
}

