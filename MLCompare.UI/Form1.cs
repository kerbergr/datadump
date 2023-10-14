using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using System.Text.RegularExpressions;
using System.IO;
using IlICompare;

namespace MLCompare.UI
{
    public partial class Form1 : Form
    {
        private IlICompare.ILIMetaData leftReaderObject;
        private IlICompare.ILIMetaData rightReaderObject;

        public List<IPipeDescription> LeftItems { get; private set; }
        public List<IPipeDescription> RightItems { get; private set; }

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
                var data =  IlICompare.InputReaderOpenXML.GetColumnsData(filename);

                data.FileLocation = filename;

                leftReaderObject = data;
                leftbindingSource1.DataSource = data.columnNames;

                listBox1.DataSource = leftbindingSource1;
            }
        }

        private ILIMetaData GetData(string filename)
        {
            ILIMetaData data = new ILIMetaData();

            var excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open(filename);
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[1];
            var row = xlWorkSheet.Rows[1];
            int max = 100;
            for (int i = 1; i <= max; i++)
            {
                Range cell = row.Cells[1,i];
                var value = cell.Value;
                if (value != null)
                    data.columnNames.Add(new ColumnMetaData(value, i - 0));

            }



            wb.Save();
            wb.Close();
            return data;

            
        }
        public class ILIMetaData
        {
            public List<ColumnMetaData> columnNames = new List<ColumnMetaData>();
        }

        public class ColumnMetaData
        {
            private static List<string> takenNames = new List<string>();

            public int index { get; set; }
            public string ColumnText { get; set; }
            public string variableName { get; set; }

            public string VariableTypeString { get; set; } = "string";

            private string RemoveBadChraters(string columnText)
            {
              
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                var me = rgx.Replace(columnText, "");
                return me;
            }

            public ColumnMetaData(string columnText, int ind)
            {
                index = ind;
                ColumnText = columnText;
                variableName = RemoveBadChraters(columnText);
                variableName = variableName.Replace(" ", "");
                if (takenNames.Contains(variableName))
                {
                    variableName = variableName + "_1";
                }
                takenNames.Add(variableName);
            }

            public Type VariableType { get; set; }
            public bool Nullible { get; set; }

            public bool isFeatureDescription { get; set; }
            public bool isPipelength { get; set; }
            public bool isOdometer { get; set; }
            public bool isDistanceFromWeld { get; set; }
            public bool isMLLength { get; set; }
         

            public override string ToString()
            {
                return ColumnText;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            var data = leftbindingSource1.DataSource as List<IlICompare.ColumnMetaData>;

            if (data == null)
            {
                MessageBox.Show(" No Columns");
                return;
            }

            if (data.Count(x=>x.isDistanceFromWeld) != 1)
            {
                MessageBox.Show(" 1 DistanceFromWeld needs to be selected");
                return;
            }
            if (data.Count(x => x.isFeatureDescription) != 1)
            {
                MessageBox.Show(" 1 isFeatureDescription needs to be selected");
                return;
            }
            if (data.Count(x => x.isMLLength) != 1)
            {
                MessageBox.Show(" 1 isMLLength needs to be selected");
                return;
            }
            if (data.Count(x => x.isOdometer) != 1)
            {
                MessageBox.Show(" 1 isOdometer needs to be selected");
                return;
            }
            if (data.Count(x => x.isPipelength) != 1)
            {
                MessageBox.Show(" 1 isPipelength needs to be selected");
                return;
            }

            MessageBox.Show("You are ready! Click to Start may take a couple minutes.");

            leftReaderObject.indexOfDescription = leftReaderObject.columnNames.First(x => x.isFeatureDescription).index;
            leftReaderObject.indexOfDistancefromWeld = leftReaderObject.columnNames.First(x => x.isDistanceFromWeld).index;
            leftReaderObject.indexOfMLLength = leftReaderObject.columnNames.First(x => x.isMLLength).index;
            leftReaderObject.indexOfOdometer = leftReaderObject.columnNames.First(x => x.isOdometer).index;
            leftReaderObject.indexOfPipelineLength = leftReaderObject.columnNames.First(x => x.isPipelength).index;


            var output = InputReaderOpenXML.ReadPipesplz(leftReaderObject, leftReaderObject.FileLocation );

            LeftItems = output;

            lblLeftCount.Text = "Number of Items: " + output.Count;

        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var data = rightBindingSource.DataSource as List<IlICompare.ColumnMetaData>;

            if (data == null)
            {
                MessageBox.Show(" No Columns");
                return;
            }

            if (data.Count(x => x.isDistanceFromWeld) != 1)
            {
                MessageBox.Show(" 1 DistanceFromWeld needs to be selected");
                return;
            }
            if (data.Count(x => x.isFeatureDescription) != 1)
            {
                MessageBox.Show(" 1 isFeatureDescription needs to be selected");
                return;
            }
            if (data.Count(x => x.isMLLength) != 1)
            {
                MessageBox.Show(" 1 isMLLength needs to be selected");
                return;
            }
            if (data.Count(x => x.isOdometer) != 1)
            {
                MessageBox.Show(" 1 isOdometer needs to be selected");
                return;
            }
            if (data.Count(x => x.isPipelength) != 1)
            {
                MessageBox.Show(" 1 isPipelength needs to be selected");
                return;
            }

            MessageBox.Show("You are ready! Click to Start may take a couple minutes.");

            rightReaderObject.indexOfDescription = rightReaderObject.columnNames.First(x => x.isFeatureDescription).index;
            rightReaderObject.indexOfDistancefromWeld = rightReaderObject.columnNames.First(x => x.isDistanceFromWeld).index;
            rightReaderObject.indexOfMLLength = rightReaderObject.columnNames.First(x => x.isMLLength).index;
            rightReaderObject.indexOfOdometer = rightReaderObject.columnNames.First(x => x.isOdometer).index;
            rightReaderObject.indexOfPipelineLength = rightReaderObject.columnNames.First(x => x.isPipelength).index;


            var output = InputReaderOpenXML.ReadPipesplz(rightReaderObject, rightReaderObject.FileLocation);

            RightItems = output;

            lblRightCount.Text = "Number of Items: " + output.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult diag = openFileDialog1.ShowDialog(this);


            if (diag == DialogResult.OK)
            {
                var filename = openFileDialog1.FileName;
                var data = IlICompare.InputReaderOpenXML.GetColumnsData(filename);

                rightReaderObject = data;
                rightBindingSource.DataSource = data.columnNames;

                listBox2.DataSource = rightBindingSource;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = !chkSimpleFeatureMatching.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var details = new PipeDetails();

            var leftPipes = details.TurnFeaturesIntoPipes(LeftItems, chkcalcweldLeft.Checked );

            var rightPipes = details.TurnFeaturesIntoPipes(RightItems, chkcalcweldRight.Checked);

            details.FirstLeft = double.Parse(txtFirstLeft.Text);
            details.FirstRight = double.Parse(txtFirstRight.Text);
            details.AddBoth(leftPipes, rightPipes);

            details.SquashList();


            var outputWriter = new OutputWriter(1);

            if (chkSimpleFeatureMatching.Checked)
            {
                var output = details.FullOutputWithFeatureMatchingFromLeftSide<GenericOutput>().ToList();
                outputWriter.Write<GenericInput, GenericInput>(txtOutputName.Text, output);
            }



        }
    }
}
