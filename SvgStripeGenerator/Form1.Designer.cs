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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.MyTextBoxHeight.Text = "100";
            // 
            // MyTextBoxWidth
            // 
            this.MyTextBoxWidth.Location = new System.Drawing.Point(165, 45);
            this.MyTextBoxWidth.Name = "MyTextBoxWidth";
            this.MyTextBoxWidth.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxWidth.TabIndex = 2;
            this.MyTextBoxWidth.Text = "206.088";
            // 
            // MyTextBoxStripes
            // 
            this.MyTextBoxStripes.Location = new System.Drawing.Point(166, 78);
            this.MyTextBoxStripes.Name = "MyTextBoxStripes";
            this.MyTextBoxStripes.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxStripes.TabIndex = 3;
            this.MyTextBoxStripes.Text = "2";
            this.MyTextBoxStripes.TextChanged += new System.EventHandler(this.MyTextBoxStripes_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 27);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MyTextBoxStripes);
            this.Controls.Add(this.MyTextBoxWidth);
            this.Controls.Add(this.MyTextBoxHeight);
            this.Controls.Add(this.MyBottonWrite);
            this.Name = "Form1";
            this.Text = "SvgWiter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyBottonWrite;
        private System.Windows.Forms.TextBox MyTextBoxHeight;
        private System.Windows.Forms.TextBox MyTextBoxWidth;
        private System.Windows.Forms.TextBox MyTextBoxStripes;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

