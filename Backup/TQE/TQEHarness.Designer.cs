namespace Travel
{
    partial class TQEHarness
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butInput1 = new System.Windows.Forms.Button();
            this.butInput3 = new System.Windows.Forms.Button();
            this.butInput2 = new System.Windows.Forms.Button();
            this.butQuoteNow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOutput.Enabled = false;
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.Location = new System.Drawing.Point(128, 169);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(175, 111);
            this.txtOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(128, 27);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(175, 81);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output (read-only)";
            // 
            // butInput1
            // 
            this.butInput1.Location = new System.Drawing.Point(13, 27);
            this.butInput1.Name = "butInput1";
            this.butInput1.Size = new System.Drawing.Size(99, 23);
            this.butInput1.TabIndex = 5;
            this.butInput1.Text = "Input 1 (ST)";
            this.butInput1.UseVisualStyleBackColor = true;
            this.butInput1.Click += new System.EventHandler(this.butInput1_Click);
            // 
            // butInput3
            // 
            this.butInput3.Location = new System.Drawing.Point(13, 85);
            this.butInput3.Name = "butInput3";
            this.butInput3.Size = new System.Drawing.Size(99, 23);
            this.butInput3.TabIndex = 6;
            this.butInput3.Text = "Input 3 (ST)";
            this.butInput3.UseVisualStyleBackColor = true;
            this.butInput3.Click += new System.EventHandler(this.butInput3_Click);
            // 
            // butInput2
            // 
            this.butInput2.Location = new System.Drawing.Point(13, 56);
            this.butInput2.Name = "butInput2";
            this.butInput2.Size = new System.Drawing.Size(99, 23);
            this.butInput2.TabIndex = 7;
            this.butInput2.Text = "Input 2 (AT)";
            this.butInput2.UseVisualStyleBackColor = true;
            this.butInput2.Click += new System.EventHandler(this.butInput2_Click);
            // 
            // butQuoteNow
            // 
            this.butQuoteNow.Location = new System.Drawing.Point(13, 169);
            this.butQuoteNow.Name = "butQuoteNow";
            this.butQuoteNow.Size = new System.Drawing.Size(99, 111);
            this.butQuoteNow.TabIndex = 8;
            this.butQuoteNow.Text = "Quote Now ! >>";
            this.butQuoteNow.UseVisualStyleBackColor = true;
            this.butQuoteNow.Click += new System.EventHandler(this.butQuoteNow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Samples";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "You can also enter your own. However, there is no validation.";
            // 
            // TQEHarness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butQuoteNow);
            this.Controls.Add(this.butInput2);
            this.Controls.Add(this.butInput3);
            this.Controls.Add(this.butInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TQEHarness";
            this.Text = "Travel Quote Harness";
            this.Load += new System.EventHandler(this.TQEHarness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butInput1;
        private System.Windows.Forms.Button butInput3;
        private System.Windows.Forms.Button butInput2;
        private System.Windows.Forms.Button butQuoteNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}