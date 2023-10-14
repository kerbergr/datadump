using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class NewJune : IPipeDescription
    {
        [Index(0)]
        public string ItemNumber { get; set; }
        [Index(1)]
        public double? OdometerDistanceft { get; set; }
        [Index(2)]
        public string Feature { get; set; }
        [Index(3)]
        public string Comments { get; set; }
        [Index(4)]
        public string WallThicknessin { get; set; }
        [Index(5)]
        public string PipeType { get; set; }
        [Index(6)]
        public string PipeGrade { get; set; }
        [Index(7)]
        public string MOPpsi { get; set; }
        [Index(8)]
        public string Depth { get; set; }
        [Index(9)]
        public string Depthin { get; set; }
        [Index(10)]
        public double? LENGTHin { get; set; }
        [Index(11)]
        public string WIDTHin { get; set; }
        [Index(12)]
        public string ORIENTATIONoclock { get; set; }
        [Index(13)]
        public string BurstPressureMB31G_psi { get; set; }
        [Index(14)]
        public string SafeBurstMB31G_psi { get; set; }
        [Index(15)]
        public string ERF_MB31G { get; set; }
        [Index(16)]
        public double? DistancetoUSWeldft { get; set; }
        [Index(17)]
        public string DistancetoDSWeldft { get; set; }
        [Index(18)]
        public double? JointNumber { get; set; }
        [Index(19)]
        public double? JointLengthft { get; set; }
        [Index(20)]
        public double? Latitiude { get; set; }
        [Index(21)]
        public double? Longitude { get; set; }
        [Index(22)]
        public double? Elevationft { get; set; }


        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {

                return DistancetoUSWeldft ?? 0;
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
                return LENGTHin ?? 0;
            }
        }

        [Ignore]
        public string FeatureDescription { get => Feature; set => throw new NotImplementedException(); }

        [Ignore]
        double IPipeDescription.Odometer { get => OdometerDistanceft ?? 0; }

        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => JointLengthft; }

    }
}