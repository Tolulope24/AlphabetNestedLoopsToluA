namespace AlphabetNestedLoopsToluA
{
    partial class frmAlphabetNestedLoops
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstAlphabetNestedLoops = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(92, 65);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstAlphabetNestedLoops
            // 
            this.lstAlphabetNestedLoops.FormattingEnabled = true;
            this.lstAlphabetNestedLoops.Location = new System.Drawing.Point(61, 137);
            this.lstAlphabetNestedLoops.Name = "lstAlphabetNestedLoops";
            this.lstAlphabetNestedLoops.Size = new System.Drawing.Size(143, 238);
            this.lstAlphabetNestedLoops.TabIndex = 1;
            // 
            // frmAlphabetNestedLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 387);
            this.Controls.Add(this.lstAlphabetNestedLoops);
            this.Controls.Add(this.btnStart);
            this.Name = "frmAlphabetNestedLoops";
            this.Text = "Alphabet Nested Loops";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstAlphabetNestedLoops;
    }
}

