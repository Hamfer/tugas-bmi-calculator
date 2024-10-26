using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var weight = inputWeight.Value;
            var height = inputHeight.Value;
            var errorList = new List<string>();
            if (weight <= 0) 
            {
                errorList.Add("Berat badan harus lebih dari 0");
            }
            if (height <= 0) 
            {
                errorList.Add("Tinggi badan harus lebih dari 0");
            }
            if (errorList.Count > 0) 
            {
                MessageBox.Show(string.Join("\n", errorList));
                return;
            }

            var person = new Person(weight, height);

            result.Text = person.CalculateBmi().ToString("0.0000");
            result.ForeColor = person.GetClassificationColor();
            classification.Text = person.GetClassificationText();
            classification.ForeColor = person.GetClassificationColor();
        }
    }
}