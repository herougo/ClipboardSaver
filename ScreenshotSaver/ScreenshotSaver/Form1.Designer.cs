namespace BmpToXConverter
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
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOutputDirectory = new System.Windows.Forms.Button();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.tbNextNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamePrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.BackColor = System.Drawing.Color.Black;
            this.rtbFeedback.ForeColor = System.Drawing.Color.White;
            this.rtbFeedback.Location = new System.Drawing.Point(12, 279);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.ReadOnly = true;
            this.rtbFeedback.Size = new System.Drawing.Size(352, 133);
            this.rtbFeedback.TabIndex = 9;
            this.rtbFeedback.TabStop = false;
            this.rtbFeedback.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(352, 39);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOutputDirectory);
            this.groupBox2.Controls.Add(this.tbOutputDirectory);
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 58);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Directory";
            // 
            // btnOutputDirectory
            // 
            this.btnOutputDirectory.Location = new System.Drawing.Point(283, 20);
            this.btnOutputDirectory.Name = "btnOutputDirectory";
            this.btnOutputDirectory.Size = new System.Drawing.Size(57, 23);
            this.btnOutputDirectory.TabIndex = 3;
            this.btnOutputDirectory.Text = "browse";
            this.btnOutputDirectory.UseVisualStyleBackColor = true;
            this.btnOutputDirectory.Click += new System.EventHandler(this.btnOutputDirectory_Click);
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(12, 22);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(265, 20);
            this.tbOutputDirectory.TabIndex = 2;
            this.tbOutputDirectory.TabStop = false;
            // 
            // btnGoTo
            // 
            this.btnGoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.Location = new System.Drawing.Point(13, 202);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(352, 39);
            this.btnGoTo.TabIndex = 11;
            this.btnGoTo.Text = "Go To File Location";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // tbNextNum
            // 
            this.tbNextNum.Location = new System.Drawing.Point(298, 97);
            this.tbNextNum.Name = "tbNextNum";
            this.tbNextNum.Size = new System.Drawing.Size(67, 20);
            this.tbNextNum.TabIndex = 12;
            this.tbNextNum.TextChanged += new System.EventHandler(this.tbNextNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Next Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name Prefix";
            // 
            // tbNamePrefix
            // 
            this.tbNamePrefix.Location = new System.Drawing.Point(96, 101);
            this.tbNamePrefix.Name = "tbNamePrefix";
            this.tbNamePrefix.Size = new System.Drawing.Size(67, 20);
            this.tbNamePrefix.TabIndex = 14;
            this.tbNamePrefix.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "This program saves image in the clipboard as a png file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNamePrefix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNextNum);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.rtbFeedback);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Clipboard Saver";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOutputDirectory;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.TextBox tbNextNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamePrefix;
        private System.Windows.Forms.Label label3;
    }
}

