using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{

    public class oldDec2022 : IPipeDescription
    {
        [Index(0)]
        public string ID { get; set; }
        [Index(1)]
        public string Feature { get; set; }
        [Index(2)]
        public double? WheelCountft { get; set; }
        [Index(3)]
        public string StaNumft { get; set; }
        [Index(4)]
        public string Depth { get; set; }
        [Index(5)]
        public string WTin { get; set; }
        [Index(6)]
        public string SMYS { get; set; }
        [Index(7)]
        public double ? Lengthin { get; set; }
        [Index(8)]
        public string Widthin { get; set; }
        [Index(9)]
        public string Orientationclock { get; set; }
        [Index(10)]
        public string PMODB31Gpsi { get; set; }
        [Index(11)]
        public string ERFMODB31GMOPP { get; set; }
        [Index(12)]
        public string ofmaxestoperpressPMOPbasedon1150 { get; set; }
        [Index(13)]
        public double? DistfromUSweldft { get; set; }
        [Index(14)]
        public string DistfromDSweldft { get; set; }
        [Index(15)]
        public string USAGM { get; set; }
        [Index(16)]
        public string DisttoUSAGMft { get; set; }
        [Index(17)]
        public string DSAGM { get; set; }
        [Index(18)]
        public string DisttoDSAGMft { get; set; }
        [Index(19)]
        public double? JointLengthft { get; set; }
        [Index(20)]
        public string Comments { get; set; }
        [Index(21)]
        public double? LAT { get; set; }
        [Index(22)]
        public double? LON { get; set; }
        [Index(23)]
        public double? ALTITUDE { get; set; }


        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {

                return DistfromUSweldft ?? 0;
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
        public string FeatureDescription { get => Feature; set => throw new NotImplementedException(); }

        [Ignore]
        double IPipeDescription.Odometer { get => WheelCountft ?? 0; }

        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => JointLengthft; }

    }
    public class oldExample2 : IPipeDescription
    {
        [Index(0)]
        public string Tool { get; set; }
        [Index(1)]
        public string WeldNumber { get; set; }
        [Index(2)]
        public double? ApproxMilepostmiles { get; set; }
        [Index(3)]
        public string ApproxMapStationft { get; set; }
        [Index(4)]
        public double? Odometerft { get; set; }
        [Index(5)]
        public string FeatureNumber { get; set; }
        [Index(6)]
        public string FeatureDescription { get; set; }
        [Index(7)]
        public string DistancetoNearestWeldft { get; set; }
        [Index(8)]
        public double? DistancetoUpstreamWeldft { get; set; }
        [Index(9)]
        public double? DistancetoDownstreamWeldft { get; set; }
        [Index(10)]
        public string DistancetoNearestAGMft { get; set; }
        [Index(11)]
        public string DistancetoUpstreamAGMft { get; set; }
        [Index(12)]
        public string DistancetoDownstreamAGMft { get; set; }
        [Index(13)]
        public string WallThicknessofJointorBoxedMetalLossAnomalyMedianin { get; set; }
        [Index(14)]
        public double? WallThicknessofJointOnlyMedianin { get; set; }
        [Index(15)]
        public double? MaxDepthfromJointMedian { get; set; }
        [Index(16)]
        public string MaxDepthToolTolerancefromJointMedian { get; set; }
        [Index(17)]
        public string DentDepth { get; set; }
        [Index(18)]
        public double? Lengthin { get; set; }
        [Index(19)]
        public string Widthin { get; set; }
        [Index(20)]
        public string Orientdeg { get; set; }
        [Index(21)]
        public double ? PipeLnthft { get; set; }
        [Index(22)]
        public double? LongSeamOrientdeg { get; set; }
        [Index(23)]
        public string B31GmodUsingMedianThicknessPsafepsi { get; set; }
        [Index(24)]
        public string B31GmodUsingMedianThicknessPsafepsi2 { get; set; }
        [Index(25)]
        public string B31GmodUsingMedianThicknessToolTolerancePsafepsi { get; set; }
        [Index(26)]
        public string B31GEffAreaUsingMedianThicknessPsafepsi { get; set; }
        [Index(27)]
        public string B31GEffAreaUsingMedianThicknessToolTolerancePsafepsi { get; set; }
        [Index(28)]
        public string B31GEffAreaUsingMedianThicknessPfailurepsi { get; set; }
        [Index(29)]
        public string B31GEffAreaUsingMedianThicknessToolTolerancePfailurepsi { get; set; }
        [Index(30)]
        public string LattitudeNAD83 { get; set; }
        [Index(31)]
        public string LongitudeNAD83 { get; set; }
        [Index(32)]
        public string ElevationAboveMeanSeaLevelNAVD88ft { get; set; }
        [Index(33)]
        public string Comments { get; set; }
        [Index(34)]
        public string ValidThicknessDataPercent { get; set; }
        [Index(35)]
        public string FeatureTypeIntExtMid { get; set; }
        [Index(36)]
        public string DepthofFeatureFromJointMedianin { get; set; }
        [Index(37)]
        public string DepthSizingTolerancein { get; set; }
        [Index(38)]
        public string DepthofFeatureFromJointMedianToolTolerancein { get; set; }
        [Index(39)]
        public string ThicknessMinimumMeasuredforMetalLossMinusToolTolerancein { get; set; }
        [Index(40)]
        public string ThicknessMinimumMeasuredTmmin { get; set; }
        [Index(41)]
        public double? API579MAOPrpsi { get; set; }
        [Index(42)]
        public string API579RSF { get; set; }
        [Index(43)]
        public string PipingSpecifications { get; set; }
        [Index(44)]
        public double? SMYSksi { get; set; }
        [Index(45)]
        public string MAOPDesignpsi { get; set; }
        [Index(46)]
        public string NominalPipeDiameterODin { get; set; }
        [Index(47)]
        public string TMedianMeasuredin { get; set; }
        [Index(48)]
        public string TMeanMeasuredin { get; set; }
        [Index(49)]
        public double? DistancefromLauncherft { get; set; }
        [Index(50)]
        public double? StationPositionft { get; set; }
        [Index(51)]
        public double? RadiusInsideMedianin { get; set; }
        [Index(52)]
        public double? RadiusInsideMeanin { get; set; }
        [Index(53)]
        public double? RadiusInsideMinin { get; set; }
        [Index(54)]
        public double? TNominalin { get; set; }



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
        double IPipeDescription.Odometer { get => Odometerft ?? 0;  }

        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => PipeLnthft;  }

    }
}