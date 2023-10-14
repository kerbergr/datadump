using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class OLDILIItem : IPipeDescription
    {
        [Index(0)]
        public string Tool { get; set; }
        [Index(1)]
        public int? WeldNumber { get; set; }
        [Index(2)]
        public string ApproxMilePost { get; set; }
        [Index(3)]
        public string ApproxMapStation { get; set; }
        [Index(4)]
        public double? Odometer { get; set; }
        [Index(5)]
        public int? FeatureNumber { get; set; }
        [Index(6)]
        public string FeatureDescription { get; set; }
        [Index(7)]
        public string DistanceToNearestWeld { get; set; }
        [Index(8)]
        public double? DistanceToNearestUpstreamWeld { get; set; }
        [Index(9)]
        public double? DistanceToNearestDownStreamWeld { get; set; }
        [Index(10)]
        public string DistanceToNearestAGM { get; set; }
        [Index(11)]
        public double? DistanceToNearestUpstreamAGM { get; set; }
        [Index(12)]
        public double? DistanceToNearestDownStreamAGM { get; set; }
        [Index(13)]
        public double? WT { get; set; }
        [Index(14)]
        public double? MaxDepth { get; set; }
        [Index(15)]
        public string SeamWeldInteraction { get; set; }
        [Index(16)]
        public double? LengthInch { get; set; }
        [Index(17)]
        public double? WidthInch { get; set; }
        [Index(18)]
        public double? OrientationDegree { get; set; }
        [Index(19)]
        public double? PipeLengthFT { get; set; }
        [Index(20)]
        public string LongStemOrientationDegree { get; set; }
        [Index(21)]
        public string AdjacenttoLongSeam { get; set; }
        [Index(22)]
        public int? B31GMAOPRating { get; set; }
        [Index(23)]
        public int? EFFAreaMAOPRating { get; set; }
        [Index(24)]
        public int? EFFBurstPressRating { get; set; }
        [Index(25)]
        public int? MaxDepthTolerance { get; set; }
        [Index(26)]
        public int? B31GMAOPRatingWTolerance { get; set; }
        [Index(27)]
        public int? EFFAreaMAOPRatingWTolerance { get; set; }
        [Index(28)]
        public int? EFFBurstPressRatingWTolerance { get; set; }
        [Index(29)]
        public double? Latitude { get; set; }
        [Index(30)]
        public double? Longitude { get; set; }
        [Index(31)]
        public double? ElevationAboveSeaLevel { get; set; }
        [Index(32)]
        public string Comment { get; set; }
        [Index(33)]
        public string MultipleApexDent { get; set; }

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
        double IPipeDescription.Odometer { get => Odometer ?? 0; }

        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => PipeLengthFT; }
    }
}