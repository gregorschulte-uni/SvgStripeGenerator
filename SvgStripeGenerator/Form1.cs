using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SvgStripeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string MySVGstart = "<svg  xmlns=\"http://www.w3.org/2000/svg\"\r\nxmlns:xlink=\"http://www.w3.org/1999/xlink\" width=\"297mm\" height=\"210mm\"> \n\r";
        string MySVGcontent = "";
        string MySVGend = "</svg>";
        string MySVG = "";
        string path = @"c:\Optomotor.svg";
        bool color = true;
        string bw = "#000000";

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MyBottonWrite_Click(object sender, EventArgs e)
        {

            for (int i = 1; i< int.Parse(MyTextBoxStripes.Text)+1; i++)
            {
                if (color) { bw = HexConverter(MyColorDialogFill.Color); } else { bw = HexConverter(MyColorDialogFill2.Color); }
                MySVGcontent = MySVGcontent +"<rect x=\""+ (i*(double.Parse(MyTextBoxWidth.Text)/int.Parse(MyTextBoxStripes.Text))).ToString(CultureInfo.CreateSpecificCulture("en-GB")) +"mm\" y=\"10mm\" height=\"100mm\" width=\""+ ((double.Parse(MyTextBoxWidth.Text) / int.Parse(MyTextBoxStripes.Text))).ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "mm\" style=\"stroke:"+ bw +"; stroke-width:0.1mm; fill: "+ bw +"  \"/> \n\r";
                color = !color;
            }

            MySVGcontent = MySVGcontent + "<rect x=\"" + (1 * (double.Parse(MyTextBoxWidth.Text) / int.Parse(MyTextBoxStripes.Text))).ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "mm\" y=\"10mm\" height=\"100mm\" width=\"" + ((double.Parse(MyTextBoxWidth.Text))).ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "mm\" style=\"stroke:#000000; stroke-width:0.1mm; fill: none  \"/> \n\r";

            MySVG = MySVGstart + MySVGcontent + MySVGend;

            MySaveFileDialog.ShowDialog();

            if (MySaveFileDialog.FileName !="")
            {
                path = Path.GetFullPath(MySaveFileDialog.FileName);
                File.WriteAllText(path, MySVG);
            }           

            
        }

        private void MyPictureBoxFillColor_Click(object sender, EventArgs e)
        {
            MyColorDialogFill.ShowDialog();
            MyPictureBoxFillColor.BackColor = MyColorDialogFill.Color;
        }
        private void MyPictureBoxFillColor2_Click(object sender, EventArgs e)
        {
            MyColorDialogFill2.ShowDialog();
            MyPictureBoxFillColor2.BackColor = MyColorDialogFill2.Color;
        }

        private void MyTextBoxWidht_leave(object sender, System.EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(MyTextBoxWidth.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                MyTextBoxWidth.Text = 206.ToString();
                return;
            }
            else if (parsedValue < 10 || parsedValue > 1000)
            {
                MessageBox.Show("Values have to be between 10 and 1000   ");
                MyTextBoxWidth.Text = 206.ToString();
                return;

            }
        }
        private void MyTextBoxStripes_leave(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(MyTextBoxStripes.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                MyTextBoxStripes.Text = 20.ToString();
                return;
            }
            else if (parsedValue < 1 || parsedValue > 200)
            {
                MessageBox.Show("Values have to be between 1 and 200   ");
                MyTextBoxStripes.Text = 20.ToString();
                return;

            }
        }

        private void MyTextBoxWidth_TextChanged(object sender, EventArgs e)
        {    
        }
        private void MyTextBoxStripes_TextChanged(object sender, EventArgs e)
        {
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

    }
}
