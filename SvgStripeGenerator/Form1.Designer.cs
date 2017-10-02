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
            this.MyColorDialogFill = new System.Windows.Forms.ColorDialog();
            this.MyPictureBoxFillColor = new System.Windows.Forms.PictureBox();
            this.MyPictureBoxFillColor2 = new System.Windows.Forms.PictureBox();
            this.MyColorDialogFill2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBoxFillColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBoxFillColor2)).BeginInit();
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
            this.MyTextBoxWidth.Text = "206";
            this.MyTextBoxWidth.TextChanged += new System.EventHandler(this.MyTextBoxWidth_TextChanged);
            this.MyTextBoxWidth.Leave += new System.EventHandler(this.MyTextBoxWidht_leave);
            // 
            // MyTextBoxStripes
            // 
            this.MyTextBoxStripes.Location = new System.Drawing.Point(166, 78);
            this.MyTextBoxStripes.Name = "MyTextBoxStripes";
            this.MyTextBoxStripes.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxStripes.TabIndex = 3;
            this.MyTextBoxStripes.Text = "20";
            this.MyTextBoxStripes.TextChanged += new System.EventHandler(this.MyTextBoxStripes_TextChanged);
            this.MyTextBoxStripes.Leave += new System.EventHandler(this.MyTextBoxStripes_leave);
            // 
            // MyPictureBoxFillColor
            // 
            this.MyPictureBoxFillColor.BackColor = System.Drawing.Color.Black;
            this.MyPictureBoxFillColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPictureBoxFillColor.Location = new System.Drawing.Point(166, 122);
            this.MyPictureBoxFillColor.Name = "MyPictureBoxFillColor";
            this.MyPictureBoxFillColor.Size = new System.Drawing.Size(26, 26);
            this.MyPictureBoxFillColor.TabIndex = 4;
            this.MyPictureBoxFillColor.TabStop = false;
            this.MyPictureBoxFillColor.Click += new System.EventHandler(this.MyPictureBoxFillColor_Click);
            // 
            // MyPictureBoxFillColor2
            // 
            this.MyPictureBoxFillColor2.BackColor = System.Drawing.Color.White;
            this.MyPictureBoxFillColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPictureBoxFillColor2.Location = new System.Drawing.Point(166, 154);
            this.MyPictureBoxFillColor2.Name = "MyPictureBoxFillColor2";
            this.MyPictureBoxFillColor2.Size = new System.Drawing.Size(26, 27);
            this.MyPictureBoxFillColor2.TabIndex = 5;
            this.MyPictureBoxFillColor2.TabStop = false;
            this.MyPictureBoxFillColor2.Click += new System.EventHandler(this.MyPictureBoxFillColor2_Click);
            // 
            // MyColorDialogFill2
            // 
            this.MyColorDialogFill2.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 304);
            this.Controls.Add(this.MyPictureBoxFillColor2);
            this.Controls.Add(this.MyPictureBoxFillColor);
            this.Controls.Add(this.MyTextBoxStripes);
            this.Controls.Add(this.MyTextBoxWidth);
            this.Controls.Add(this.MyTextBoxHeight);
            this.Controls.Add(this.MyBottonWrite);
            this.Name = "Form1";
            this.Text = "SvgWiter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBoxFillColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBoxFillColor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyBottonWrite;
        private System.Windows.Forms.TextBox MyTextBoxHeight;
        private System.Windows.Forms.TextBox MyTextBoxWidth;
        private System.Windows.Forms.TextBox MyTextBoxStripes;
        private System.Windows.Forms.ColorDialog MyColorDialogFill;
        private System.Windows.Forms.PictureBox MyPictureBoxFillColor;
        private System.Windows.Forms.PictureBox MyPictureBoxFillColor2;
        private System.Windows.Forms.ColorDialog MyColorDialogFill2;
    }
}

