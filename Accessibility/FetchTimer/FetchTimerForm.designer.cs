/*************************************************************************************************
 *
 * File: FetchTimerForm.Designer.cs
 *
 * Description: Design-time code for the interface.
 * 
 * See FetchTimerForm.cs for a full description of the sample.
 *
 *     
 *  This file is part of the Microsoft WinfFX SDK Code Samples.
 * 
 *  Copyright (C) Microsoft Corporation.  All rights reserved.
 * 
 * This source code is intended only as a supplement to Microsoft
 * Development Tools and/or on-line documentation.  See these other
 * materials for detailed information regarding Microsoft code samples.
 * 
 * THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
 * PARTICULAR PURPOSE.
 * 
 *************************************************************************************************/
namespace FetchTimer
{
    partial class FetchTimerForm
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
            gbScope = new System.Windows.Forms.GroupBox();
            cbDescendants = new System.Windows.Forms.CheckBox();
            cbChildren = new System.Windows.Forms.CheckBox();
            comboElement = new System.Windows.Forms.CheckBox();
            tbOutput = new System.Windows.Forms.TextBox();
            lblOutput = new System.Windows.Forms.Label();
            btnProps = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rbNone = new System.Windows.Forms.RadioButton();
            rbFull = new System.Windows.Forms.RadioButton();
            gbScope.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbScope
            // 
            gbScope.Controls.Add(cbDescendants);
            gbScope.Controls.Add(cbChildren);
            gbScope.Controls.Add(comboElement);
            gbScope.Location = new System.Drawing.Point(239, 76);
            gbScope.Name = "gbScope";
            gbScope.Size = new System.Drawing.Size(166, 93);
            gbScope.TabIndex = 3;
            gbScope.TabStop = false;
            gbScope.Text = "TreeScope";
            // 
            // cbDescendants
            // 
            cbDescendants.AutoSize = true;
            cbDescendants.Location = new System.Drawing.Point(6, 68);
            cbDescendants.Name = "cbDescendants";
            cbDescendants.Size = new System.Drawing.Size(146, 28);
            cbDescendants.TabIndex = 2;
            cbDescendants.Text = "&Descendants";
            cbDescendants.UseVisualStyleBackColor = true;
            cbDescendants.CheckedChanged += cbDescendants_CheckedChanged;
            // 
            // cbChildren
            // 
            cbChildren.AutoSize = true;
            cbChildren.Location = new System.Drawing.Point(6, 44);
            cbChildren.Name = "cbChildren";
            cbChildren.Size = new System.Drawing.Size(109, 28);
            cbChildren.TabIndex = 1;
            cbChildren.Text = "&Children";
            cbChildren.UseVisualStyleBackColor = true;
            // 
            // comboElement
            // 
            comboElement.AutoCheck = false;
            comboElement.AutoSize = true;
            comboElement.Checked = true;
            comboElement.CheckState = System.Windows.Forms.CheckState.Checked;
            comboElement.Location = new System.Drawing.Point(6, 20);
            comboElement.Name = "comboElement";
            comboElement.Size = new System.Drawing.Size(106, 28);
            comboElement.TabIndex = 0;
            comboElement.TabStop = false;
            comboElement.Text = "Element";
            comboElement.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            tbOutput.BackColor = System.Drawing.SystemColors.Window;
            tbOutput.Location = new System.Drawing.Point(20, 221);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbOutput.Size = new System.Drawing.Size(385, 165);
            tbOutput.TabIndex = 6;
            tbOutput.TabStop = false;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new System.Drawing.Point(20, 156);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new System.Drawing.Size(71, 24);
            lblOutput.TabIndex = 5;
            lblOutput.Text = "Results";
            lblOutput.Visible = false;
            // 
            // btnProps
            // 
            btnProps.Location = new System.Drawing.Point(156, 39);
            btnProps.Name = "btnProps";
            btnProps.Size = new System.Drawing.Size(100, 23);
            btnProps.TabIndex = 1;
            btnProps.Text = "&Get Properties";
            btnProps.UseVisualStyleBackColor = true;
            btnProps.Click += btnProps_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(578, 48);
            label1.TabIndex = 0;
            label1.Text = "Activate this window, put the cursor over an element\nanywhere on the screen, and invoke the button by pressing Alt+G.";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(68, 151);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(85, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clea&r";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNone);
            groupBox1.Controls.Add(rbFull);
            groupBox1.Location = new System.Drawing.Point(36, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(197, 69);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "AutomationElementMode";
            // 
            // rbNone
            // 
            rbNone.AutoSize = true;
            rbNone.Location = new System.Drawing.Point(51, 44);
            rbNone.Name = "rbNone";
            rbNone.Size = new System.Drawing.Size(82, 28);
            rbNone.TabIndex = 1;
            rbNone.Text = "&None";
            rbNone.UseVisualStyleBackColor = true;
            // 
            // rbFull
            // 
            rbFull.AutoSize = true;
            rbFull.Checked = true;
            rbFull.Location = new System.Drawing.Point(51, 20);
            rbFull.Name = "rbFull";
            rbFull.Size = new System.Drawing.Size(66, 28);
            rbFull.TabIndex = 0;
            rbFull.TabStop = true;
            rbFull.Text = "&Full";
            rbFull.UseVisualStyleBackColor = true;
            // 
            // FetchTimerForm
            // 
            ClientSize = new System.Drawing.Size(692, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(btnProps);
            Controls.Add(lblOutput);
            Controls.Add(tbOutput);
            Controls.Add(gbScope);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "FetchTimerForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "UI Automation Caching Sample";
            TopMost = true;
            gbScope.ResumeLayout(false);
            gbScope.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbScope;
        private System.Windows.Forms.CheckBox comboElement;
        private System.Windows.Forms.CheckBox cbDescendants;
        private System.Windows.Forms.CheckBox cbChildren;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnProps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbFull;
    }
}

