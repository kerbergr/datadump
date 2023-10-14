using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    class newexample2 : IPipeDescription
    {
        [Index(0)]
        public string ILITool { get; set; }
        [Index(1)]
        public string PipeJointNumber { get; set; }
        [Index(2)]
        public double? ApproxMilepost { get; set; }
        [Index(3)]
        public string ApproxMapStation { get; set; }
        [Index(4)]
        public double? Odometer { get; set; }
        [Index(5)]
        public string FeatureNumber { get; set; }
        [Index(6)]
        public string FeatureDescription { get; set; }
        [Index(7)]
        public string DistancetoNearestWeld { get; set; }
        [Index(8)]
        public double? DistancetoUpstreamWeld { get; set; }
        [Index(9)]
        public double? DistancetoDownstreamWeld { get; set; }
        [Index(10)]
        public string DistancetoNearestAGM { get; set; }
        [Index(11)]
        public string DistancetoUpstreamAGM { get; set; }
        [Index(12)]
        public double? DistancetoDownstreamAGM { get; set; }
        [Index(13)]
        public string WT  { get; set; }
        [Index(14)]
        public string MaxDept { get; set; }
        [Index(15)]
        public string MaxDepthTolerance { get; set; }
        [Index(16)]
        public double? Length
        { get; set; }
        [Index(17)]
        public string Width
        { get; set; }
        [Index(18)]
        public string Oreintation
        { get; set; }
        [Index(19)]
        public double? PipeLength { get; set; }
        [Index(20)]
        public string LongSeamOrient { get; set; }
        [Index(21)]
        public string dot85SafeMAOPRating { get; set; }
        [Index(22)]
        public string dot85SafeMAOPRatingTolerance { get; set; }
        [Index(23)]
        public string EffAreaB31GofAPI579SafeMAOPRating { get; set; }
        [Index(24)]
        public string EffAreaB31GofAPI579SafeMAOPRating2 { get; set; }
        [Index(25)]
        public string EffAreaB31GofAPI579BurstPressRating { get; set; }
        [Index(26)]
        public string EffAreaB31GofAPI579BurstPressRatingTolerance { get; set; }
        [Index(27)]
        public double? LatitudeNAD83 { get; set; }
        [Index(28)]
        public double? LongitudeNAD83 { get; set; }
        [Index(29)]
        public double? ElevationAboveMeanSeaLevelNAVD88 { get; set; }
        [Index(30)]
        public string Comments { get; set; }


        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {

                return DistancetoUpstreamWeld ?? 0;
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
                return Length ?? 0;
            }
        }

        [Ignore]
        double IPipeDescription.Odometer { get => Odometer ?? 0; }

        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => PipeLength;  }

    }

}