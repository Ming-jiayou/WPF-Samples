namespace InsertTextW32Target
{
    partial class Target
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
            tbTarget = new System.Windows.Forms.TextBox();
            rtbTarget = new System.Windows.Forms.RichTextBox();
            tbTargetMultiLine = new System.Windows.Forms.TextBox();
            lblSingleLineTextBox = new System.Windows.Forms.Label();
            lblMultilineTextBox = new System.Windows.Forms.Label();
            lblRichTextBox = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // tbTarget
            // 
            tbTarget.AccessibleDescription = "Target TextBox";
            tbTarget.AccessibleName = "tbTarget";
            tbTarget.AllowDrop = true;
            tbTarget.Location = new System.Drawing.Point(218, 412);
            tbTarget.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            tbTarget.MaxLength = 2;
            tbTarget.Name = "tbTarget";
            tbTarget.Size = new System.Drawing.Size(292, 30);
            tbTarget.TabIndex = 0;
            // 
            // rtbTarget
            // 
            rtbTarget.AcceptsTab = true;
            rtbTarget.AccessibleDescription = "Target RichTextBox";
            rtbTarget.AccessibleName = "rtbTarget";
            rtbTarget.Location = new System.Drawing.Point(218, 190);
            rtbTarget.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            rtbTarget.Name = "rtbTarget";
            rtbTarget.Size = new System.Drawing.Size(292, 174);
            rtbTarget.TabIndex = 2;
            rtbTarget.Text = "";
            // 
            // tbTargetMultiLine
            // 
            tbTargetMultiLine.AcceptsReturn = true;
            tbTargetMultiLine.AcceptsTab = true;
            tbTargetMultiLine.AccessibleDescription = "Target multi-line TextBox";
            tbTargetMultiLine.AccessibleName = "mtbTarget";
            tbTargetMultiLine.AllowDrop = true;
            tbTargetMultiLine.Location = new System.Drawing.Point(218, 22);
            tbTargetMultiLine.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            tbTargetMultiLine.Multiline = true;
            tbTargetMultiLine.Name = "tbTargetMultiLine";
            tbTargetMultiLine.Size = new System.Drawing.Size(292, 131);
            tbTargetMultiLine.TabIndex = 1;
            tbTargetMultiLine.Tag = "test";
            // 
            // lblSingleLineTextBox
            // 
            lblSingleLineTextBox.AccessibleDescription = "Label for single line TextBox";
            lblSingleLineTextBox.AccessibleName = "lblSingleLineTextBox";
            lblSingleLineTextBox.Location = new System.Drawing.Point(22, 412);
            lblSingleLineTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblSingleLineTextBox.Name = "lblSingleLineTextBox";
            lblSingleLineTextBox.Size = new System.Drawing.Size(185, 98);
            lblSingleLineTextBox.TabIndex = 3;
            lblSingleLineTextBox.Text = "Single Line TextBox (2 character limit) (tbTarget)";
            // 
            // lblMultilineTextBox
            // 
            lblMultilineTextBox.AccessibleDescription = "Label for multi-line TextBox";
            lblMultilineTextBox.AccessibleName = "lblMultiLineTextBox";
            lblMultilineTextBox.Location = new System.Drawing.Point(22, 22);
            lblMultilineTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblMultilineTextBox.Name = "lblMultilineTextBox";
            lblMultilineTextBox.Size = new System.Drawing.Size(185, 92);
            lblMultilineTextBox.TabIndex = 4;
            lblMultilineTextBox.Text = "Multi-Line TextBox (tbTargetMultiLine)";
            // 
            // lblRichTextBox
            // 
            lblRichTextBox.AccessibleDescription = "Label for rich text TextBox";
            lblRichTextBox.AccessibleName = "lblRichTextBox";
            lblRichTextBox.Location = new System.Drawing.Point(22, 190);
            lblRichTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblRichTextBox.Name = "lblRichTextBox";
            lblRichTextBox.Size = new System.Drawing.Size(172, 70);
            lblRichTextBox.TabIndex = 5;
            lblRichTextBox.Text = "RichTextBox (rtbTarget)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(28, 74);
            checkBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(125, 28);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Read-only";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(28, 244);
            checkBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(125, 28);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Read-only";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(28, 491);
            checkBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(125, 28);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Read-only";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // Target
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(535, 576);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lblRichTextBox);
            Controls.Add(lblMultilineTextBox);
            Controls.Add(lblSingleLineTextBox);
            Controls.Add(tbTargetMultiLine);
            Controls.Add(rtbTarget);
            Controls.Add(tbTarget);
            Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            Name = "Target";
            Text = "Target";
            Load += Target_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.RichTextBox rtbTarget;
        private System.Windows.Forms.TextBox tbTargetMultiLine;
        private System.Windows.Forms.Label lblSingleLineTextBox;
        private System.Windows.Forms.Label lblMultilineTextBox;
        private System.Windows.Forms.Label lblRichTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

