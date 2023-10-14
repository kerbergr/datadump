using System.Collections.Generic;

namespace IlICompare
{
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
}
