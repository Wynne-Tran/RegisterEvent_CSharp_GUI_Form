﻿namespace AssignmentForm
{
    partial class Customer_Details_Form
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
            this.btnDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelCustDetail = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.lblero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDetail.Location = new System.Drawing.Point(250, 727);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(6);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(236, 67);
            this.btnDetail.TabIndex = 0;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Lists: ";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.Location = new System.Drawing.Point(552, 642);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(298, 31);
            this.txtID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(110, 642);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter customer\'s ID:";
            // 
            // btnCancelCustDetail
            // 
            this.btnCancelCustDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelCustDetail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCustDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelCustDetail.Location = new System.Drawing.Point(552, 727);
            this.btnCancelCustDetail.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelCustDetail.Name = "btnCancelCustDetail";
            this.btnCancelCustDetail.Size = new System.Drawing.Size(236, 67);
            this.btnCancelCustDetail.TabIndex = 4;
            this.btnCancelCustDetail.Text = "Cancel";
            this.btnCancelCustDetail.UseVisualStyleBackColor = false;
            this.btnCancelCustDetail.Click += new System.EventHandler(this.btnCancelCustDetail_Click);
            // 
            // txtList
            // 
            this.txtList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtList.Location = new System.Drawing.Point(118, 85);
            this.txtList.Margin = new System.Windows.Forms.Padding(6);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(856, 381);
            this.txtList.TabIndex = 5;
            
            // 
            // lblero
            // 
            this.lblero.AutoSize = true;
            this.lblero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblero.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblero.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblero.Location = new System.Drawing.Point(332, 538);
            this.lblero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblero.Name = "lblero";
            this.lblero.Size = new System.Drawing.Size(0, 36);
            this.lblero.TabIndex = 6;
            // 
            // Customer_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1104, 871);
            this.Controls.Add(this.lblero);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnCancelCustDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetail);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Customer_Details_Form";
            this.Text = "Customer_Details_Form";
            this.Load += new System.EventHandler(this.Customer_Details_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelCustDetail;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label lblero;
    }
}