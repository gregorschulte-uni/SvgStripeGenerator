namespace SvgStripeGenerator
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
            this.MyBottonWrite = new System.Windows.Forms.Button();
            this.MyTextBoxHeight = new System.Windows.Forms.TextBox();
            this.MyTextBoxWidth = new System.Windows.Forms.TextBox();
            this.MyTextBoxStripes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MyBottonWrite
            // 
            this.MyBottonWrite.Location = new System.Drawing.Point(157, 194);
            this.MyBottonWrite.Name = "MyBottonWrite";
            this.MyBottonWrite.Size = new System.Drawing.Size(108, 29);
            this.MyBottonWrite.TabIndex = 0;
            this.MyBottonWrite.Text = "Write SVG";
            this.MyBottonWrite.UseVisualStyleBackColor = true;
            this.MyBottonWrite.Click += new System.EventHandler(this.MyBottonWrite_Click);
            // 
            // MyTextBoxHeight
            // 
            this.MyTextBoxHeight.Location = new System.Drawing.Point(166, 12);
            this.MyTextBoxHeight.Name = "MyTextBoxHeight";
            this.MyTextBoxHeight.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxHeight.TabIndex = 1;
            // 
            // MyTextBoxWidth
            // 
            this.MyTextBoxWidth.Location = new System.Drawing.Point(165, 45);
            this.MyTextBoxWidth.Name = "MyTextBoxWidth";
            this.MyTextBoxWidth.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxWidth.TabIndex = 2;
            // 
            // MyTextBoxStripes
            // 
            this.MyTextBoxStripes.Location = new System.Drawing.Point(166, 78);
            this.MyTextBoxStripes.Name = "MyTextBoxStripes";
            this.MyTextBoxStripes.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxStripes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.MyTextBoxStripes);
            this.Controls.Add(this.MyTextBoxWidth);
            this.Controls.Add(this.MyTextBoxHeight);
            this.Controls.Add(this.MyBottonWrite);
            this.Name = "Form1";
            this.Text = "SvgWiter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyBottonWrite;
        private System.Windows.Forms.TextBox MyTextBoxHeight;
        private System.Windows.Forms.TextBox MyTextBoxWidth;
        private System.Windows.Forms.TextBox MyTextBoxStripes;
    }
}

