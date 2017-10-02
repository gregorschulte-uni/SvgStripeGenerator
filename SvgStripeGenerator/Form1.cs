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

namespace SvgStripeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string MySVGstart = "<svg  xmlns=\"http://www.w3.org/2000/svg\"\r\nxmlns:xlink=\"http://www.w3.org/1999/xlink\" width=\"297mm\" height=\"210mm\"> \n\r";
        string MySVGcontent = "\n\r";
        string MySVGend = "</svg>";
        string MySVG = "";
        string path = @"c:\temp\MyTest.svg";
        bool color = true;
        string bw = "#000000";



        private void MyBottonWrite_Click(object sender, EventArgs e)
        {

            for (int i = 1; i< int.Parse(MyTextBoxStripes.Text)+1; i++)
            {
                if (color) { bw = HexConverter(colorDialog1.Color); } else { bw = HexConverter(colorDialog2.Color); }
                MySVGcontent = MySVGcontent +"<rect x=\""+ (i*(double.Parse(MyTextBoxWidth.Text)/int.Parse(MyTextBoxStripes.Text))).ToString() +"mm\" y=\"10mm\" height=\"100mm\" width=\""+ ((double.Parse(MyTextBoxWidth.Text) / int.Parse(MyTextBoxStripes.Text))).ToString() + "mm\" style=\"stroke:"+ bw +"; stroke-width:0.1mm; fill: "+ bw +"  \"/> \n\r";
                color = !color;
            }

            MySVGcontent = MySVGcontent + "<rect x=\"" + (1 * (double.Parse(MyTextBoxWidth.Text) / int.Parse(MyTextBoxStripes.Text))).ToString() + "mm\" y=\"10mm\" height=\"100mm\" width=\"" + ((double.Parse(MyTextBoxWidth.Text))).ToString() + "mm\" style=\"stroke:#000000; stroke-width:0.1mm; fill: none  \"/> \n\r";


            MySVG = MySVGstart + MySVGcontent + MySVGend;
            File.WriteAllText(path, MySVG);

            Console.Beep();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyTextBoxStripes_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(MyTextBoxStripes.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }
            else if (parsedValue<1 || parsedValue>100  )
            {
                MessageBox.Show("Values have to be between 1 and 100   ");
                return;

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            pictureBox2.BackColor = colorDialog2.Color;
        }
    }
}
