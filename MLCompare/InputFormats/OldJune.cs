using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class OldJune : IPipeDescription
    {
        [Index(0)]
        public string Jno { get; set; }
        [Index(1)]
        public double? Jlenft { get; set; }
        [Index(2)]
        public string tin { get; set; }
        [Index(3)]
        public double? touswft { get; set; }
        [Index(4)]
        public string todswft { get; set; }
        [Index(5)]
        public string oclock { get; set; }
        [Index(6)]
        public double? LogDistance { get; set; }
        [Index(7)]
        public string SeverityRule { get; set; }
        [Index(8)]
        public string _event { get; set; }
        [Index(9)]
        public string depth { get; set; }
        [Index(10)]
        public string ODReduction { get; set; }
        [Index(11)]
        public double? lengthin { get; set; }
        [Index(12)]
        public string widthin { get; set; }
        [Index(13)]
        public string _internal { get; set; }
        [Index(14)]
        public string ERF_085dl { get; set; }
        [Index(15)]
        public string RPR_085dl { get; set; }
        [Index(16)]
        public string SMYSpsi { get; set; }
        [Index(17)]
        public string Comment { get; set; }
        [Index(18)]
        public double? Latitude { get; set; }
        [Index(19)]
        public double? Longitude { get; set; }


        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {

                return touswft ?? 0;
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
                return lengthin ?? 0;
            }
        }

        [Ignore]
        public string FeatureDescription { get => _event; set => throw new NotImplementedException(); }

        [Ignore]
        double IPipeDescription.Odometer { get => LogDistance ?? 0; }

        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => Jlenft; }

    }

    public class oldOct : IPipeDescription
    {
       

        [Index(0)]
        public string GlobalGW { get; set; }
        [Index(1)]
        public string Tool { get; set; }
        [Index(2)]
        public string WeldNumber { get; set; }
        [Index(3)]
        public double? ApproxMilepostmiles { get; set; }
        [Index(4)]
        public string ApproxMapStationft { get; set; }
        [Index(5)]
        public double? Odometerft { get; set; }
        [Index(6)]
        public string FeatureNumber { get; set; }
        [Index(7)]
        public string _FeatureDescription { get; set; }
        [Index(8)]
        public string DistancetoNearestWeldft { get; set; }
        [Index(9)]
        public double? DistancetoUpstreamWeldft { get; set; }
        [Index(10)]
        public double? DistancetoDownstreamWeldft { get; set; }
        [Index(11)]
        public string DistancetoNearestAGMft { get; set; }
        [Index(12)]
        public string DistancetoUpstreamAGMft { get; set; }
        [Index(13)]
        public double? DistancetoDownstreamAGMft { get; set; }
        [Index(14)]
        public double? WallThicknessofJointorBoxedMetalLossAnomalyMedianin { get; set; }
        [Index(15)]
        public double? WallThicknessofJointOnlyMedianin { get; set; }
        [Index(16)]
        public string MaxDepthfromJointMedian { get; set; }
        [Index(17)]
        public string MaxDepthToolTolerancefromJointMedian { get; set; }
        [Index(18)]
        public string DentDepth { get; set; }
        [Index(19)]
        public double ? Lengthin { get; set; }
        [Index(20)]
        public string Widthin { get; set; }
        [Index(21)]
        public string Orientdeg { get; set; }
        [Index(22)]
        public double? PipeLnthft { get; set; }
        [Index(23)]
        public string LongSeamOrientdeg { get; set; }
        [Index(24)]
        public string B31GmodUsingMedianThicknessPsafepsi { get; set; }
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
        public double? ValidThicknessDataPercent { get; set; }
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
        public double? ThicknessMinimumMeasuredTmmin { get; set; }
        [Index(41)]
        public string API579MAOPrpsi { get; set; }
        [Index(42)]
        public string API579RSF { get; set; }
        [Index(43)]
        public string PipingSpecifications { get; set; }
        [Index(44)]
        public string SMYSksi { get; set; }
        [Index(45)]
        public string MAOPDesignpsi { get; set; }
        [Index(46)]
        public string NominalPipeDiameter { get; set; }
        [Index(47)]
        public string ODin { get; set; }
        [Index(48)]
        public double? TMedianMeasuredin { get; set; }
        [Index(49)]
        public double? TMeanMeasuredin { get; set; }
        [Index(50)]
        public double? DistancefromLauncherft { get; set; }
        [Index(51)]
        public double? StationPositionft { get; set; }
        [Index(52)]
        public double? RadiusInsideMedianin { get; set; }
        [Index(53)]
        public double? RadiusInsideMeanin { get; set; }
        [Index(54)]
        public double? RadiusInsideMinin { get; set; }
        [Index(55)]
        public double? TNominalin { get; set; }

        [Ignore]
        public string FeatureType { get; set; }

        private double SetableDistancefromWeld = double.NaN;
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
        public string FeatureDescription { get => _FeatureDescription; set => throw new NotImplementedException(); }

        [Ignore]
        double IPipeDescription.Odometer { get => Odometerft ?? 0; }

        [Ignore]
        double? IPipeDescription.PipeLengthFT
        {
            get
            {
                if (FeatureType == "Weld")
                    return DistancetoDownstreamWeldft;
                else
                {
                    return (DistancetoUpstreamWeldft ?? 0) + (DistancetoDownstreamWeldft ?? 0);
                }
            }
        }
    }
}