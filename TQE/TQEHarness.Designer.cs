namespace TQE
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.txtOutput.ForeColor = System.Drawing.Color.Gold;
            this.txtOutput.Location = new System.Drawing.Point(171, 208);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(232, 136);
            this.txtOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInput.ForeColor = System.Drawing.Color.Orange;
            this.txtInput.Location = new System.Drawing.Point(171, 33);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(232, 99);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output (read-only)";
            // 
            // butInput1
            // 
            this.butInput1.Location = new System.Drawing.Point(17, 33);
            this.butInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butInput1.Name = "butInput1";
            this.butInput1.Size = new System.Drawing.Size(132, 28);
            this.butInput1.TabIndex = 5;
            this.butInput1.Text = "Input 1 (ST)";
            this.butInput1.UseVisualStyleBackColor = true;
            this.butInput1.Click += new System.EventHandler(this.butInput1_Click);
            // 
            // butInput3
            // 
            this.butInput3.Location = new System.Drawing.Point(17, 105);
            this.butInput3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butInput3.Name = "butInput3";
            this.butInput3.Size = new System.Drawing.Size(132, 28);
            this.butInput3.TabIndex = 6;
            this.butInput3.Text = "Input 3 (ST)";
            this.butInput3.UseVisualStyleBackColor = true;
            this.butInput3.Click += new System.EventHandler(this.butInput3_Click);
            // 
            // butInput2
            // 
            this.butInput2.Location = new System.Drawing.Point(17, 69);
            this.butInput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butInput2.Name = "butInput2";
            this.butInput2.Size = new System.Drawing.Size(132, 28);
            this.butInput2.TabIndex = 7;
            this.butInput2.Text = "Input 2 (AT)";
            this.butInput2.UseVisualStyleBackColor = true;
            this.butInput2.Click += new System.EventHandler(this.butInput2_Click);
            // 
            // butQuoteNow
            // 
            this.butQuoteNow.Location = new System.Drawing.Point(17, 208);
            this.butQuoteNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butQuoteNow.Name = "butQuoteNow";
            this.butQuoteNow.Size = new System.Drawing.Size(132, 137);
            this.butQuoteNow.TabIndex = 8;
            this.butQuoteNow.Text = "Quote Now ! >>";
            this.butQuoteNow.UseVisualStyleBackColor = true;
            this.butQuoteNow.Click += new System.EventHandler(this.butQuoteNow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Samples";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "You can also enter your own. However, there is no validation.";
            // 
            // TQEHarness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 369);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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