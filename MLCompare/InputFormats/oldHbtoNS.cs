using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class oldhbtons : IPipeDescription
    {
        [Index(0)]
        public string BHIIdentifier { get; set; }
        [Index(1)]
        public string PipelineFeature { get; set; }
        [Index(2)]
        public string INTEXTIDOD { get; set; }
        [Index(3)]
        public double? Odometerft { get; set; }
        [Index(4)]
        public double? DistancetoNextPipelineFeatureft { get; set; }
        [Index(5)]
        public double? WTin { get; set; }
        [Index(6)]
        public string PipeGradepsi { get; set; }
        [Index(7)]
        public string PipeDescription { get; set; }
        [Index(8)]
        public double? PipeDiameterin { get; set; }
        [Index(9)]
        public string MOPpsi { get; set; }
        [Index(10)]
        public string Depth { get; set; }
        [Index(11)]
        public string Depthin { get; set; }
        [Index(12)]
        public string Lengthin { get; set; }
        [Index(13)]
        public string Widthin { get; set; }
        [Index(14)]
        public string OClockOrientationhhmm { get; set; }
        [Index(15)]
        public string mB31GBurstpsi { get; set; }
        [Index(16)]
        public string ERF { get; set; }
        [Index(17)]
        public string EffDepth { get; set; }
        [Index(18)]
        public string EffLengthin { get; set; }
        [Index(19)]
        public string EffAreaBurstpsi { get; set; }
        [Index(20)]
        public string UpstreamUSReferenceName { get; set; }
        [Index(21)]
        public string DistanceToUSReferenceft { get; set; }
        [Index(22)]
        public string DownstreamDSReferenceName { get; set; }
        [Index(23)]
        public double? DistanceFromDSReferenceft { get; set; }
        [Index(24)]
        public double? DistancetoUSWeldft { get; set; }
        [Index(25)]
        public double? DistancetoDSWeldft { get; set; }
        [Index(26)]
        public string Length2ndUSJointft { get; set; }
        [Index(27)]
        public string LengthUSJointft { get; set; }
        [Index(28)]
        public double ? LengthDefectJointft { get; set; }
        [Index(29)]
        public string DefectJointNumber { get; set; }
        [Index(30)]
        public double? LengthDSJointft { get; set; }
        [Index(31)]
        public double? Length2ndDSJointft { get; set; }
        [Index(32)]
        public double? XYZInformationNAD83Latitude { get; set; }
        [Index(33)]
        public double? XYZInformationNAD83Longitude { get; set; }
        [Index(34)]
        public double? XYZInformationNAVD88Elevationft { get; set; }
        [Index(35)]
        public string Comments { get; set; }



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
                double res = 0;
                double.TryParse(Lengthin,out res);
                return res;
            }
        }


        [Ignore]
        string IPipeDescription.FeatureDescription { get => PipelineFeature;  }
        [Ignore] 
        double IPipeDescription.Odometer { get => Odometerft??0;  }
        [Ignore] 
        double? IPipeDescription.PipeLengthFT { get => LengthDefectJointft;  }
    }

  
    }