﻿
namespace ContactBookMVC.View
{
    partial class AddContactForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.nameLB = new System.Windows.Forms.Label();
            this.surnameLB = new System.Windows.Forms.Label();
            this.adressLB = new System.Windows.Forms.Label();
            this.numberLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(197, 85);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(223, 22);
            this.nameTB.TabIndex = 0;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(197, 154);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(223, 22);
            this.surnameTB.TabIndex = 1;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(197, 227);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(223, 22);
            this.addressTB.TabIndex = 2;
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(197, 311);
            this.numberTB.Multiline = true;
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(223, 22);
            this.numberTB.TabIndex = 3;
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Location = new System.Drawing.Point(94, 89);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(45, 17);
            this.nameLB.TabIndex = 4;
            this.nameLB.Text = "Name";
            // 
            // surnameLB
            // 
            this.surnameLB.AutoSize = true;
            this.surnameLB.Location = new System.Drawing.Point(94, 154);
            this.surnameLB.Name = "surnameLB";
            this.surnameLB.Size = new System.Drawing.Size(65, 17);
            this.surnameLB.TabIndex = 5;
            this.surnameLB.Text = "Surname";
            // 
            // adressLB
            // 
            this.adressLB.AutoSize = true;
            this.adressLB.Location = new System.Drawing.Point(94, 230);
            this.adressLB.Name = "adressLB";
            this.adressLB.Size = new System.Drawing.Size(60, 17);
            this.adressLB.TabIndex = 6;
            this.adressLB.Text = "Address";
            // 
            // numberLB
            // 
            this.numberLB.AutoSize = true;
            this.numberLB.Location = new System.Drawing.Point(94, 311);
            this.numberLB.Name = "numberLB";
            this.numberLB.Size = new System.Drawing.Size(58, 17);
            this.numberLB.TabIndex = 7;
            this.numberLB.Text = "Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberLB);
            this.Controls.Add(this.adressLB);
            this.Controls.Add(this.surnameLB);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label surnameLB;
        private System.Windows.Forms.Label adressLB;
        private System.Windows.Forms.Label numberLB;
        private System.Windows.Forms.Button button1;
    }
}