using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class DataFrom2020 : IPipeDescription
    {

        [Index(0)]
        public string ItemNumber { get; set; }
        [Index(1)]
        public string JointNumber { get; set; }
        [Index(2)]
        public double? JointLengthft { get; set; }
        [Index(3)]
        public string DisttoUSGWft { get; set; }
        [Index(4)]
        public double? DisttoDSGWft { get; set; }
        [Index(5)]
        public double? AbsoluteDistanceft { get; set; }
        [Index(6)]
        public string Feature { get; set; }
        [Index(7)]
        public string ExtInt { get; set; }
        [Index(8)]
        public string Depth { get; set; }
        [Index(9)]
        public string Depthin { get; set; }
        [Index(10)]
        public string Lengthin { get; set; }
        [Index(11)]
        public string Widthin { get; set; }
        [Index(12)]
        public string Oclockhhmm { get; set; }
        [Index(13)]
        public string Comments { get; set; }
        [Index(14)]
        public string PipeType { get; set; }
        [Index(15)]
        public string WTin { get; set; }
        [Index(16)]
        public string PipeGrade { get; set; }
        [Index(17)]
        public double? PipeODin { get; set; }
        [Index(18)]
        public string MOP { get; set; }
        [Index(19)]
        public string LongSeam { get; set; }
        [Index(20)]
        public string ERF { get; set; }
        [Index(21)]
        public string SafeBurstPressure { get; set; }
        [Index(22)]
        public string BurstPressure { get; set; }
        [Index(23)]
        public double? Latitudedeg { get; set; }
        [Index(24)]
        public double? Longitudedeg { get; set; }
        [Index(25)]
        public double? Elevationft { get; set; }

        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                double res = 0;
                double.TryParse(DisttoUSGWft, out res);
                return res;
            }
            set
            {
                throw new Exception();
            }
        }
        [Ignore]
        public double MLLength
        {
            get
            {
                double res = 0;
                double.TryParse(Lengthin, out res);
                return res;
            }
        }
        [Ignore]
        string IPipeDescription.FeatureDescription { get => Feature;  }
        [Ignore]
        double IPipeDescription.Odometer { get => AbsoluteDistanceft ?? 0;  }
        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => JointLengthft;  }
    }
}