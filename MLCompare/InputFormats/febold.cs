using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class febold : IPipeDescription
    {

        [Index(0)]
        public string TDWIndex { get; set; }
        [Index(1)]
        public string WeldNumber { get; set; }
        [Index(2)]
        public double? ApproxMilepostmiles { get; set; }
        [Index(3)]
        public string AdjstdMapStaCDS { get; set; }
        [Index(4)]
        public double? Odometerft { get; set; }
        [Index(5)]
        public string ScalingFactor { get; set; }
        [Index(6)]
        public string FeatureDescription { get; set; }
        [Index(7)]
        public string DistancetoNearestWeldft { get; set; }
        [Index(8)]
        public string DistancetoUpstreamWeldft { get; set; }
        [Index(9)]
        public string DistancetoDownStreamWeldft { get; set; }
    [Index(10)]
    public string DistancetoNearestAGMft { get; set; }
    [Index(11)]
    public string DistancetoUpstreamAGMft { get; set; }
    [Index(12)]
    public string DistancetoDownStreamAGMft { get; set; }
[Index(13)]
public double? WTin { get; set; }
[Index(14)]
public string MaxDepth { get; set; }
[Index(15)]
public string SeamWeldInteraction { get; set; }
[Index(16)]
public string Lengthin { get; set; }
[Index(17)]
public string Widthin { get; set; }
[Index(18)]
public string Orientdeg { get; set; }
[Index(19)]
public string PipeLengthft { get; set; }
[Index(20)]
public string LongSeamOrientdeg { get; set; }
[Index(21)]
public string _085DLB31GSafeMAOPRatingpsig
{ get; set; }
[Index(22)]
public string EffAreaSafeMAOPRatingpsig { get; set; }
[Index(23)]
public string EffAreaBurstPressRatingpsig { get; set; }
[Index(24)]
public string MaxDepthwTolerance { get; set; }
[Index(25)]
public string _085DLB31GSafeMAOPRatingwTolerancepsig
{ get; set; }
[Index(26)]
public string EffAreaSafeMAOPRatingwTolerancepsig { get; set; }
[Index(27)]
public string EffAreaBurstPressRatingwTolerancepsig { get; set; }
[Index(28)]
public double? LatitudeNAD83 { get; set; }
[Index(29)]
public double? LongitudeNAD83 { get; set; }
[Index(30)]
public double? ElevationAboveSeaLevelftNAVD88 { get; set; }
[Index(31)]
public string CommentsRationale { get; set; }

[Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                double res = 0;
                double.TryParse(DistancetoUpstreamWeldft, out res);
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
        string IPipeDescription.FeatureDescription { get => FeatureDescription;  }
        [Ignore]
        double IPipeDescription.Odometer { get => Odometerft ?? 0;  }
        [Ignore]
        double? IPipeDescription.PipeLengthFT {
            get
            {
                double res = 0;
                double.TryParse(PipeLengthft, out res);
                return res;
            }
        }
    }

    public class febnew : IPipeDescription
    {

        [Index(0)]
        public string ILITool { get; set; }
        [Index(1)]
        public string PBF_ID { get; set; }
        [Index(2)]
        public string AdjstdWeldNumber { get; set; }
        [Index(3)]
        public double? AdjstdMilepost { get; set; }
        [Index(4)]
        public string AdjstdSta { get; set; }
        [Index(5)]
        public string STADiff { get; set; }
        [Index(6)]
        public string ODODiff { get; set; }
        [Index(7)]
        public string Multiplier { get; set; }
        [Index(8)]
        public double? Odometerft { get; set; }
        [Index(9)]
        public string OdometerDistancetoStartofBoxft { get; set; }
        [Index(10)]
        public string FeatureNumber { get; set; }
        [Index(11)]
        public string FeatureDescription { get; set; }
        [Index(12)]
        public string DistancetoNearestWeldft { get; set; }
        [Index(13)]
        public string DistancetoUpstreamWeldft { get; set; }
        [Index(14)]
        public double? DistancetoDownstreamWeldft { get; set; }
        [Index(15)]
        public string DistanceFromTopofPipeft { get; set; }
        [Index(16)]
        public string DistancetoNearestAGMft { get; set; }
        [Index(17)]
        public string DistancetoUpstreamAGMft { get; set; }
        [Index(18)]
        public double? DistancetoDownstreamAGMft { get; set; }
        [Index(19)]
        public double? WTin { get; set; }
        [Index(20)]
        public string MaxDepth { get; set; }
        [Index(21)]
        public string MaxDepthTolerance { get; set; }
        [Index(22)]
        public string Lengthin { get; set; }
        [Index(23)]
        public string Widthin { get; set; }
        [Index(24)]
        public string OreintationDegrees { get; set; }
        [Index(25)]
        public double? PipeLengthft { get; set; }
        [Index(26)]
        public string LongSeamOrientDegrees { get; set; }
        [Index(27)]
        public string _085DLSafeMAOPRatingpsig { get; set; }
    [Index(28)]
    public string _085DLSafeMAOPRatingTolerancepsig { get; set; }
[Index(29)]
public string EffAreaB31GofAPI579SafeMAOPRatingpsig { get; set; }
[Index(30)]
public string EffAreaB31GofAPI579SafeMAOPRatingTolerancepsig { get; set; }
[Index(31)]
public string EffAreaB31GofAPI579BurstPressRatingpsig { get; set; }
[Index(32)]
public string EffAreaB31GofAPI579BurstPressRatingTolerancepsig { get; set; }
[Index(33)]
public double? LatitudeNAD83 { get; set; }
[Index(34)]
public double? LongitudeNAD83 { get; set; }
[Index(35)]
public double? ElevationAboveMeanSeaLevelNAVD88ft { get; set; }
[Index(36)]
public string Comments { get; set; }
[Index(37)]
public double? PipeSizein { get; set; }
[Index(38)]
public string PipeGrade { get; set; }
[Index(39)]
public string PipeType { get; set; }
[Index(40)]
public string MOPpsi { get; set; }


[Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                double res = 0;
                double.TryParse(DistancetoUpstreamWeldft, out res);
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
        string IPipeDescription.FeatureDescription { get => FeatureDescription; }
        [Ignore]
        double IPipeDescription.Odometer { get => Odometerft ?? 0; }
        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => PipeLengthft ?? 0; }

    }
}