using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MLCompare
{

    public class GenericInput : IPipeDescription
    {
        public GenericInput(ILIMetaData classDescription)
        {
            classdata = classDescription;
        }

        public void SetValues(List<string> valuez)
        {
            values = valuez;
        }



        public List<string> values = new List<string>();
        private ILIMetaData classdata;
        private string _ft;

        public double DistanceFromWeld
        {
            get
            {
                double res = 0;
                double.TryParse( values[classdata.indexOfDistancefromWeld], out res);
                return res;
            }
            set
            {
                throw new Exception();
            }
        }
        public double MLLength
        {
            get
            {
                double res = 0;
                double.TryParse(values[classdata.indexOfMLLength], out res);
                return res;

            }
        }


        string IPipeDescription.FeatureDescription { get => values[classdata.indexOfDescription]; }
        double IPipeDescription.Odometer { get
            {
                {
                    double res = 0;
                    double.TryParse(values[classdata.indexOfOdometer], out res);
                    return res;
                }; 
            } 
        }

        double? IPipeDescription.PipeLengthFT
        {
            get
            {
                {
                    double res = 0;
                    double.TryParse(values[classdata.indexOfPipelineLength], out res);
                    return res;
                };
            }
        }
        public string FeatureType { get; set; }
    }

    public class ILIMetaData
    {

        public string FileLocation { get; set; }
        public List<ColumnMetaData> columnNames = new List<ColumnMetaData>();
        public int indexOfDescription;
        public int indexOfPipelineLength;
        public int indexOfOdometer;
        public int indexOfDistancefromWeld;
        public int indexOfMLLength;
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
}
