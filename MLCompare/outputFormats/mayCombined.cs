using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class mayCombinedItems
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
        public string DistancetoUpstreamWeldft { get; set; }
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
        public string Lengthin { get; set; }
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
        public double? Comments { get; set; }
        [Index(33)]
        public string PipeSizein { get; set; }
        [Index(34)]
        public double? PipeGrade { get; set; }
        [Index(35)]
        public string PipeType { get; set; }
        [Index(36)]
        public string MOPpsi { get; set; }

        [Index(37)]
        public string r_ILITool { get; set; }
        [Index(38)]
        public string r_AdjstdWeldNumber { get; set; }
        [Index(39)]
        public string r_AdjstdApproxMilepost { get; set; }
        [Index(40)]
        public string r_AdjstdApproxMapStation_FT { get; set; }
        [Index(41)]
        public string r_Odometer_FT { get; set; }
        [Index(42)]
        public string r_OdometerDistancetoStartofBox_FT { get; set; }
        [Index(43)]
        public string r_FeatureNumber { get; set; }
        [Index(44)]
        public string r_FeatureDescription { get; set; }
        [Index(45)]
        public string r_DistancetoNearestWeld_FT { get; set; }
        [Index(46)]
        public string r_DistancetoUpstreamWeld_FT { get; set; }
        [Index(47)]
        public string r_DistancetoDownstreamWeld_FT { get; set; }
        [Index(48)]
        public string r_DistanceFromTopofPipe_FT { get; set; }
        [Index(49)]
        public string r_DistancetoNearestAGM_FT { get; set; }
        [Index(50)]
        public string r_DistancetoUpstreamAGM_FT { get; set; }
        [Index(51)]
        public string r_DistancetoDownstreamAGM_FT { get; set; }
        [Index(52)]
        public string r_WTin { get; set; }
        [Index(53)]
        public string r_MaxDepth { get; set; }
        [Index(54)]
        public string r_MaxDepthTolerance { get; set; }
        [Index(55)]
        public string r_Lengthin { get; set; }
        [Index(56)]
        public string r_Widthin { get; set; }
        [Index(57)]
        public string r_OreintationDegrees { get; set; }
        [Index(58)]
        public string r_PipeLengthft { get; set; }
        [Index(59)]
        public string r_LongSeamOrientDegrees { get; set; }
        [Index(60)]
        public string r_085DLSafeMAOPRatingpsig { get; set; }
        [Index(61)]
        public string r_085DLSafeMAOPRatingTolerancepsig { get; set; }
        [Index(62)]
        public string r_EffAreaB31GofAPI579SafeMAOPRatingpsig { get; set; }
        [Index(63)]
        public string r_EffAreaB31GofAPI579SafeMAOPRatingTolerancepsig { get; set; }
        [Index(64)]
        public string r_EffAreaB31GofAPI579BurstPressRatingpsig { get; set; }
        [Index(65)]
        public string r_EffAreaB31GofAPI579BurstPressRatingTolerancepsig { get; set; }
        [Index(66)]
        public string r_LatitudeNAD83 { get; set; }
        [Index(67)]
        public string r_LongitudeNAD83 { get; set; }
        [Index(68)]
        public string r_ElevationAboveMeanSeaLevelNAVD88ft { get; set; }
        [Index(69)]
        public string r_Comments { get; set; }
        [Index(70)]
        public string r_PipeSizein { get; set; }
        [Index(71)]
        public string r_PipeGrade { get; set; }
        [Index(72)]
        public string r_PipeType { get; set; }
        [Index(73)]
        public string r_MOPpsi { get; set; }



    }
}