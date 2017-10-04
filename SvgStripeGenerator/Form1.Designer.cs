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
            this.MyLabelHeight = new System.Windows.Forms.Label();
            this.MyLabelWidth = new System.Windows.Forms.Label();
            this.MyLabelStripes = new System.Windows.Forms.Label();
            this.MySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MyLabelColor1 = new System.Windows.Forms.Label();
            this.MyLabelColor2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBoxFillColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBoxFillColor2)).BeginInit();
            this.SuspendLayout();
            // 
            // MyBottonWrite
            // 
            this.MyBottonWrite.Location = new System.Drawing.Point(28, 194);
            this.MyBottonWrite.Name = "MyBottonWrite";
            this.MyBottonWrite.Size = new System.Drawing.Size(237, 29);
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
            this.MyTextBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MyTextBoxWidth
            // 
            this.MyTextBoxWidth.Location = new System.Drawing.Point(166, 46);
            this.MyTextBoxWidth.Name = "MyTextBoxWidth";
            this.MyTextBoxWidth.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxWidth.TabIndex = 2;
            this.MyTextBoxWidth.Text = "207";
            this.MyTextBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyTextBoxWidth.TextChanged += new System.EventHandler(this.MyTextBoxWidth_TextChanged);
            this.MyTextBoxWidth.Leave += new System.EventHandler(this.MyTextBoxWidht_leave);
            // 
            // MyTextBoxStripes
            // 
            this.MyTextBoxStripes.Location = new System.Drawing.Point(166, 81);
            this.MyTextBoxStripes.Name = "MyTextBoxStripes";
            this.MyTextBoxStripes.Size = new System.Drawing.Size(100, 26);
            this.MyTextBoxStripes.TabIndex = 3;
            this.MyTextBoxStripes.Text = "20";
            this.MyTextBoxStripes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MyTextBoxStripes.TextChanged += new System.EventHandler(this.MyTextBoxStripes_TextChanged);
            this.MyTextBoxStripes.Leave += new System.EventHandler(this.MyTextBoxStripes_leave);
            // 
            // MyPictureBoxFillColor
            // 
            this.MyPictureBoxFillColor.BackColor = System.Drawing.Color.Black;
            this.MyPictureBoxFillColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPictureBoxFillColor.Location = new System.Drawing.Point(166, 122);
            this.MyPictureBoxFillColor.Name = "MyPictureBoxFillColor";
            this.MyPictureBoxFillColor.Size = new System.Drawing.Size(99, 26);
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
            this.MyPictureBoxFillColor2.Size = new System.Drawing.Size(99, 27);
            this.MyPictureBoxFillColor2.TabIndex = 5;
            this.MyPictureBoxFillColor2.TabStop = false;
            this.MyPictureBoxFillColor2.Click += new System.EventHandler(this.MyPictureBoxFillColor2_Click);
            // 
            // MyColorDialogFill2
            // 
            this.MyColorDialogFill2.Color = System.Drawing.Color.White;
            // 
            // MyLabelHeight
            // 
            this.MyLabelHeight.AutoSize = true;
            this.MyLabelHeight.Location = new System.Drawing.Point(24, 15);
            this.MyLabelHeight.Name = "MyLabelHeight";
            this.MyLabelHeight.Size = new System.Drawing.Size(106, 20);
            this.MyLabelHeight.TabIndex = 6;
            this.MyLabelHeight.Text = "Height in mm:";
            // 
            // MyLabelWidth
            // 
            this.MyLabelWidth.AutoSize = true;
            this.MyLabelWidth.Location = new System.Drawing.Point(24, 49);
            this.MyLabelWidth.Name = "MyLabelWidth";
            this.MyLabelWidth.Size = new System.Drawing.Size(104, 20);
            this.MyLabelWidth.TabIndex = 7;
            this.MyLabelWidth.Text = "Width in mm: ";
            // 
            // MyLabelStripes
            // 
            this.MyLabelStripes.AutoSize = true;
            this.MyLabelStripes.Location = new System.Drawing.Point(24, 84);
            this.MyLabelStripes.Name = "MyLabelStripes";
            this.MyLabelStripes.Size = new System.Drawing.Size(141, 20);
            this.MyLabelStripes.TabIndex = 8;
            this.MyLabelStripes.Text = "Number of Stripes:";
            // 
            // MySaveFileDialog
            // 
            this.MySaveFileDialog.DefaultExt = "svg";
            this.MySaveFileDialog.FileName = "Optomotor";
            this.MySaveFileDialog.InitialDirectory = "%USERPROFILE%";
            // 
            // MyLabelColor1
            // 
            this.MyLabelColor1.AutoSize = true;
            this.MyLabelColor1.Location = new System.Drawing.Point(24, 128);
            this.MyLabelColor1.Name = "MyLabelColor1";
            this.MyLabelColor1.Size = new System.Drawing.Size(63, 20);
            this.MyLabelColor1.TabIndex = 9;
            this.MyLabelColor1.Text = "Color 1:";
            // 
            // MyLabelColor2
            // 
            this.MyLabelColor2.AutoSize = true;
            this.MyLabelColor2.Location = new System.Drawing.Point(24, 161);
            this.MyLabelColor2.Name = "MyLabelColor2";
            this.MyLabelColor2.Size = new System.Drawing.Size(63, 20);
            this.MyLabelColor2.TabIndex = 10;
            this.MyLabelColor2.Text = "Color 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 238);
            this.Controls.Add(this.MyLabelColor2);
            this.Controls.Add(this.MyLabelColor1);
            this.Controls.Add(this.MyLabelStripes);
            this.Controls.Add(this.MyLabelWidth);
            this.Controls.Add(this.MyLabelHeight);
            this.Controls.Add(this.MyPictureBoxFillColor2);
            this.Controls.Add(this.MyPictureBoxFillColor);
            this.Controls.Add(this.MyTextBoxStripes);
            this.Controls.Add(this.MyTextBoxWidth);
            this.Controls.Add(this.MyTextBoxHeight);
            this.Controls.Add(this.MyBottonWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label MyLabelHeight;
        private System.Windows.Forms.Label MyLabelWidth;
        private System.Windows.Forms.Label MyLabelStripes;
        private System.Windows.Forms.SaveFileDialog MySaveFileDialog;
        private System.Windows.Forms.Label MyLabelColor1;
        private System.Windows.Forms.Label MyLabelColor2;
    }
}

