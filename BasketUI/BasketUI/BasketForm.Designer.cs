﻿namespace BasketUI
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
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BreadButton);
            this.Controls.Add(this.MilkButton);
            this.Controls.Add(this.ButterButton);
            this.Name = "BasketForm";
            this.Text = "BasketApp";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButterButton;
        public System.Windows.Forms.Button MilkButton;
        public System.Windows.Forms.Button BreadButton;
    }
}

