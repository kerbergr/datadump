using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IlICompare
{
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
