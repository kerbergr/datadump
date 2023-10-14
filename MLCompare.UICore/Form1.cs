using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLCompare;
namespace MLCompare.UICore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult diag = openFileDialog1.ShowDialog(this);


            if (diag == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;



                var data = InputReader.GetData(filename);

                data.FileLocation = filename;

                InputReaderOpenXML.ReadPipesplz(filename, data);


                bindingSource1.DataSource = data.columnNames;

                listBox1.DataSource = bindingSource1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
