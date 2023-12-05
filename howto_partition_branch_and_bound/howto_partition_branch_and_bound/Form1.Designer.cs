namespace howto_partition_branch_and_bound
{
    partial class Form1
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
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItems2 = new System.Windows.Forms.TextBox();
            this.txtItems1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPartition = new System.Windows.Forms.Button();
            this.lblNumValues = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNodesVisited = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTotal2
            // 
            this.txtTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal2.Location = new System.Drawing.Point(278, 257);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.ReadOnly = true;
            this.txtTotal2.Size = new System.Drawing.Size(69, 20);
            this.txtTotal2.TabIndex = 26;
            // 
            // txtTotal1
            // 
            this.txtTotal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal1.Location = new System.Drawing.Point(203, 257);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.ReadOnly = true;
            this.txtTotal1.Size = new System.Drawing.Size(69, 20);
            this.txtTotal1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Totals:";
            // 
            // txtItems2
            // 
            this.txtItems2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtItems2.Location = new System.Drawing.Point(278, 26);
            this.txtItems2.Multiline = true;
            this.txtItems2.Name = "txtItems2";
            this.txtItems2.ReadOnly = true;
            this.txtItems2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtItems2.Size = new System.Drawing.Size(69, 225);
            this.txtItems2.TabIndex = 23;
            this.txtItems2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItems1
            // 
            this.txtItems1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtItems1.Location = new System.Drawing.Point(203, 26);
            this.txtItems1.Multiline = true;
            this.txtItems1.Name = "txtItems1";
            this.txtItems1.ReadOnly = true;
            this.txtItems1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtItems1.Size = new System.Drawing.Size(69, 225);
            this.txtItems1.TabIndex = 22;
            this.txtItems1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(200, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Results:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPartition
            // 
            this.btnPartition.Location = new System.Drawing.Point(107, 27);
            this.btnPartition.Name = "btnPartition";
            this.btnPartition.Size = new System.Drawing.Size(75, 23);
            this.btnPartition.TabIndex = 20;
            this.btnPartition.Text = "Partition";
            this.btnPartition.UseVisualStyleBackColor = true;
            this.btnPartition.Click += new System.EventHandler(this.btnPartition_Click);
            // 
            // lblNumValues
            // 
            this.lblNumValues.Location = new System.Drawing.Point(12, 11);
            this.lblNumValues.Name = "lblNumValues";
            this.lblNumValues.Size = new System.Drawing.Size(69, 13);
            this.lblNumValues.TabIndex = 18;
            this.lblNumValues.Text = "Values:";
            this.lblNumValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nodes Visited:";
            // 
            // txtNodesVisited
            // 
            this.txtNodesVisited.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNodesVisited.Location = new System.Drawing.Point(93, 293);
            this.txtNodesVisited.Name = "txtNodesVisited";
            this.txtNodesVisited.ReadOnly = true;
            this.txtNodesVisited.Size = new System.Drawing.Size(100, 20);
            this.txtNodesVisited.TabIndex = 28;
            this.txtNodesVisited.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTime.Location = new System.Drawing.Point(93, 319);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Time:";
            // 
            // lstValues
            // 
            this.lstValues.FormattingEnabled = true;
            this.lstValues.IntegralHeight = false;
            this.lstValues.Location = new System.Drawing.Point(12, 27);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(69, 224);
            this.lstValues.TabIndex = 31;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPartition;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 351);
            this.Controls.Add(this.lstValues);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNodesVisited);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItems2);
            this.Controls.Add(this.txtItems1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPartition);
            this.Controls.Add(this.lblNumValues);
            this.Name = "Form1";
            this.Text = "howto_partition_branch_and_bound";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItems2;
        private System.Windows.Forms.TextBox txtItems1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPartition;
        private System.Windows.Forms.Label lblNumValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNodesVisited;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstValues;
    }
}

