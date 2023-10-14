using CsvHelper.Configuration.Attributes;
using System;

namespace MLCompare
{
    class mayNew : IPipeDescription
    {
        [Index(0)]
        public string ILITool { get; set; }
        [Index(1)]
        public string AdjstdWeldNumber { get; set; }
        [Index(2)]
        public double? AdjstdApproxMilepost { get; set; }
        [Index(3)]
        public string AdjstdApproxMapStationft { get; set; }
        [Index(4)]
        public double? Odometerft { get; set; }
        [Index(5)]
        public string OdometerDistancetoStartofBoxft { get; set; }
        [Index(6)]
        public string FeatureNumber { get; set; }
        [Index(7)]
        public string FeatureDescription { get; set; }
        [Index(8)]
        public string DistancetoNearestWeldft { get; set; }
        [Index(9)]
        public double ? DistancetoUpstreamWeldft { get; set; }
        [Index(10)]
        public string DistancetoDownstreamWeldft { get; set; }
        [Index(11)]
        public double? DistanceFromTopofPipeft { get; set; }
        [Index(12)]
        public string DistancetoNearestAGMft { get; set; }
        [Index(13)]
        public string DistancetoUpstreamAGMft { get; set; }
        [Index(14)]
        public string DistancetoDownstreamAGMft { get; set; }
        [Index(15)]
        public double? WTin { get; set; }
        [Index(16)]
        public double? MaxDepth { get; set; }
        [Index(17)]
        public string MaxDepthTolerance { get; set; }
        [Index(18)]
        public double? Lengthin { get; set; }
        [Index(19)]
        public string Widthin { get; set; }
        [Index(20)]
        public string OreintationDegrees { get; set; }
        [Index(21)]
        public string PipeLengthft { get; set; }
        [Index(22)]
        public double? LongSeamOrientDegrees { get; set; }
        [Index(23)]
        public string _085DLSafeMAOPRatingpsig { get; set; }
        [Index(24)]
        public string _085DLSafeMAOPRatingTolerancepsig { get; set; }
        [Index(25)]
        public string EffAreaB31GofAPI579SafeMAOPRatingpsig { get; set; }
        [Index(26)]
        public string EffAreaB31GofAPI579SafeMAOPRatingTolerancepsig { get; set; }
        [Index(27)]
        public string EffAreaB31GofAPI579BurstPressRatingpsig { get; set; }
        [Index(28)]
        public string EffAreaB31GofAPI579BurstPressRatingTolerancepsig { get; set; }
        [Index(29)]
        public string LatitudeNAD83 { get; set; }
        [Index(30)]
        public double? LongitudeNAD83 { get; set; }
        [Index(31)]
        public double? ElevationAboveMeanSeaLevelNAVD88ft { get; set; }
        [Index(32)]
        public string Comments { get; set; }
        [Index(33)]
        public double? PipeSizein { get; set; }
        [Index(34)]
        public string PipeGrade { get; set; }
        [Index(35)]
        public string PipeType { get; set; }
        [Index(36)]
        public string MOPpsi { get; set; }

        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {

                return DistancetoUpstreamWeldft ?? 0;
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
                return Lengthin ?? 0;
            }
        }
        [Ignore]
        double IPipeDescription.Odometer { get => Odometerft ?? 0; }
        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => PipeSizein; }

    }
}
