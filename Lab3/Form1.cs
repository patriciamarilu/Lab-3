//Grading ID: R5665
// CIS 199 - 01. Lab 3
// Due: February 9,2020
// This program uses a form to calculate the diameter, surface area and volume of a sphere through the radius.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double r; // radius input
            double diameter; // value of diameter 
            double area; // value of area 
            double volume;// value of volume 

            //Radius input in the textbox
            r = double.Parse(radiusinput.Text);

            diameter = 2 * r; // formula to calculate the diameter of the spehere
            area = 4 * Math.PI * Math.Pow(r, 2); // formula to calculate the surface area of the spehere
            volume = (4 / 3) * Math.PI * Math.Pow(r, 3); // formula to calculate the volume of the spehere

            diameterinput.Text = $"{diameter:F2}"; // result of the diameter 
            areainput.Text = $"{area:F2}"; // result of the surface area 
            volumeinput.Text = $"{volume:F2}"; // result of the volume 


        }
    }
}
