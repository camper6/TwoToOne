using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TwoToOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TwoToOne();
        }

        public void TwoToOne()
        {
            const int columnCount = 4;
            const int rowCount = 2;
            // Create an instance of the ListBox.
            ListBox listBox1 = new ListBox();
            // Set the size and location of the ListBox.
            listBox1.Size = new System.Drawing.Size(200, 200);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Add the ListBox to the form.
            this.Controls.Add(listBox1);

            Char[] oneDimensional = new Char[columnCount * rowCount];
            Char[,] twoDimensional = new Char[columnCount, rowCount] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };

            // convert to one dimension
            for (int c = 0; c < columnCount; c++)
            {
                for (int r = 0; r < rowCount; r++)
                {
                    oneDimensional[c * rowCount + r] = twoDimensional[c, r];
                }
            }

            //printing one dimensional array
            for (int i = 0; i < columnCount * rowCount; i++)
            {
                listBox1.Items.Add(oneDimensional[i]);
            }
        }
    }
}
