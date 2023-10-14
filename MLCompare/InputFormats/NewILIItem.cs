using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{

    public class EmptySpace 
    {
        [Index(0)]
        public string Empty { get; set; } = "";

    }

        public class NewILIItem : IPipeDescription
    {
        [Index(0)]
        public string ILITool { get; set; }
        [Index(1)]
        public int? PipeJointNumber { get; set; }
        [Index(2)]
        public double? ApproxMilePost { get; set; }
        [Index(3)]
        public string ApproxMapStation { get; set; }
        [Index(4)]
        public double? Odometer { get; set; }


        [Index(5)]
        public string OdometerDistanceToPeakDepth { get; set; }
        [Index(6)]
        public int? FeatureNumber { get; set; }
        [Index(7)]
        public string FeatureDescription { get; set; }
        [Index(8)]
        public string DistanceToNearestWeld { get; set; }
        [Index(9)]
        public double? DistanceToNearestUpstreamWeld { get; set; }
        [Index(10)]
        public double? DistanceToNearestDownStreamWeld { get; set; }
        [Index(11)]
        public string DistanceToNearestAGM { get; set; }
        [Index(12)]
        public double? DistanceToNearestUpstreamAGM { get; set; }
        [Index(13)]
        public double? DistanceToNearestDownStreamAGM { get; set; }
        [Index(14)]
        public double? WT { get; set; }
        [Index(15)]
        public double? MaxDepth { get; set; }
        [Index(16)]
        public double? LengthInch { get; set; }
        [Index(17)]
        public double? WidthInch { get; set; }
        [Index(18)]
        public double? OrientationDegree { get; set; }

        [Index(19)]
        public double? OrientationPeakDepthDegree { get; set; }
        [Index(20)]
        public double? PipeLengthFT { get; set; }

        [Index(21)]
        public string LongStemOrientationDegree { get; set; }
        [Index(22)]
        public int? o85DLSafeMAOPRating { get; set; }

        [Index(23)]
        public int? EffAreaB31GAPI579MAOPRating { get; set; }
        [Index(24)]
        public int? EffAreaB31GAPI579AreaBurstPressRating { get; set; }
        [Index(25)]
        public int? MaxDepthTolerance { get; set; }
        [Index(26)]
        public int? o85DLSafeMAOPRatingWTolerance { get; set; }
        [Index(27)]
        public int? EffAreaB31GAPI579MAOPRatingWTolerance { get; set; }
        [Index(28)]
        public int? EffAreaB31GAPI579AreaBurstPressRatingWTolerance { get; set; }
        [Index(29)]
        public double? Latitude { get; set; }
        [Index(30)]
        public double? Longitude { get; set; }
        [Index(31)]
        public double? ElevationAboveSeaLevel { get; set; }
        [Index(32)]
        public string Comment { get; set; }
        [Index(33)]
        public double? PipeSize { get; set; }
        [Index(34)]
        public string PipeGrade { get; set; }
        [Index(35)]
        public string PipeType { get; set; }
        [Index(36)]
        public int? MOP { get; set; }
        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {

                return DistanceToNearestUpstreamWeld ?? 0;
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
                return LengthInch ?? 0;
            }
        }
        [Ignore]
        double IPipeDescription.Odometer { get => Odometer ??0;  }
        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => PipeLengthFT;  }
    }
}