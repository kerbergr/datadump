using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class Datafrom2018 : IPipeDescription
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
        public double? DistanceToUSft { get; set; }
        [Index(22)]
        public string DownstreamDSReferenceName { get; set; }
        [Index(23)]
        public double? DistanceFromDSReferenceft { get; set; }
        [Index(24)]
        public double? DistancetoUSWeldft { get; set; }
        [Index(25)]
        public double? DistancetoDSWeldft { get; set; }
        [Index(26)]
        public double? Length2ndUSJointft { get; set; }
        [Index(27)]
        public double? LengthUSJointft { get; set; }
        [Index(28)]
        public double? LengthDefectJointft { get; set; }
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



    public class Datafrom2018v2 : IPipeDescription
    {

        [Index(0)]
        public string FeatureNumbersequentialorder { get; set; }
        [Index(1)]
        public string VendorSpecificFeatureName { get; set; }
    [Index(2)]
    public string StandardFeatureName { get; set; }
    [Index(3)]
    public string INTEXTIDOD { get; set; }
    [Index(4)]
    public double? Odometer { get; set; }
    [Index(5)]
    public string StationNumber { get; set; }
    [Index(6)]
    public double ? DistancetoUSweld { get; set; }
    [Index(7)]
    public string DistancetoDSweld { get; set; }
    [Index(8)]
    public double? JointLength { get; set; }
    [Index(9)]
    public string DefectJointNumber { get; set; }
    [Index(10)]
    public string UpstreamUSReferenceName { get; set; }
    [Index(11)]
    public string UpstreamUSReferenceDistanceFrom { get; set; }
    [Index(12)]
    public string DownstreamDSReferenceName { get; set; }
    [Index(13)]
    public string DownstreamDSReferenceDistanceTo { get; set; }
    [Index(14)]
    public string Diameter { get; set; }
    [Index(15)]
    public double? NominalWallThickness { get; set; }
    [Index(16)]
    public double? MeasuredWallThickness { get; set; }
    [Index(17)]
    public string PipeGradeSMYS { get; set; }
    [Index(18)]
    public string LongSeamOrientation { get; set; }
    [Index(19)]
    public string MetalLossDepthPercentage { get; set; }
    [Index(20)]
    public string MetalLossDepthInch { get; set; }
    [Index(21)]
    public string DeformationDepthPercentages { get; set; }
    [Index(22)]
    public string DeformationDepthInches { get; set; }
    [Index(23)]
    public string CrackDepthPercentages { get; set; }
    [Index(24)]
    public string CrackDepthInches { get; set; }
    [Index(25)]
    public string Length { get; set; }
    [Index(26)]
    public string Width { get; set; }
    [Index(27)]
    public string Orientation { get; set; }
    [Index(28)]
    public string MOP { get; set; }
    [Index(29)]
    public string ModifiedB31GPburst { get; set; }
    [Index(30)]
    public string ModifiedB31GPsafe { get; set; }
    [Index(31)]
    public string DesignPressure72SMYS { get; set; }
    [Index(32)]
    public string ERF { get; set; }
    [Index(33)]
    public string RPR { get; set; }
    [Index(34)]
    public string EffectiveAreaPburst { get; set; }
    [Index(35)]
    public string EffectiveAreaPsafe { get; set; }
    [Index(36)]
    public string GroupNumber { get; set; }
    [Index(37)]
    public string GroupCategory { get; set; }
    [Index(38)]
    public string NAD83Latittude { get; set; }
    [Index(39)]
    public string NAD83Longititude { get; set; }
    [Index(40)]
    public double? NAVD88elevation { get; set; }
    [Index(41)]
    public string Comments { get; set; }
    [Index(42)]
    public string POFclassification { get; set; }
    [Index(43)]
    public string ExcavationRepairRequired { get; set; }
    [Index(44)]
    public string SPLCNotes { get; set; }
    [Index(45)]
    public string ToolTypeTechnology { get; set; }
    [Index(46)]
    public string LengthAx { get; set; }
    [Index(47)]
    public string WidthAy { get; set; }



    [Ignore]
        public string FeatureType { get; set; }


        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                return DistancetoUSweld ?? 0;
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
                double.TryParse(Length, out res);
                return res;
            }
        }

        [Ignore]
        string IPipeDescription.FeatureDescription { get => VendorSpecificFeatureName; }
        [Ignore]
        double IPipeDescription.Odometer { get => Odometer ?? 0; }
        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => JointLength; }
    }


    public class xcollinsold : IPipeDescription
    {
        [Index(0)]
        public string JointNumber { get; set; }
        [Index(1)]
        public string JointLengthft { get; set; }
        [Index(2)]
        public double? Distance { get; set; }
        [Index(3)]
        public string blank { get; set; }
        [Index(4)]
        public string Event { get; set; }
        [Index(5)]
        public string MaxDepth { get; set; }
        [Index(6)]
        public string DentDepth { get; set; }
        [Index(7)]
        public string Width_in { get; set; }
        [Index(8)]
        public string Length_in { get; set; }
        [Index(9)]
        public string Orientation { get; set; }
        [Index(10)]
        public string IDOD { get; set; }
        [Index(11)]
        public string ClusterID { get; set; }
        [Index(12)]
        public string Dimc { get; set; }
        [Index(13)]
        public string ToolTolerance { get; set; }
        [Index(14)]
        public string USWeldDistance { get; set; }
        [Index(15)]
        public string DSWeldDistance { get; set; }
        [Index(16)]
        public string MinSpeedmph { get; set; }
        [Index(17)]
        public string MaxSpeedmph { get; set; }
        [Index(18)]
        public string WT { get; set; }
        [Index(19)]
        public string PipeGrade { get; set; }
        [Index(20)]
        public string LSType { get; set; }
        [Index(21)]
        public string MAOP { get; set; }
        [Index(22)]
        public string ERFB31G { get; set; }
        [Index(23)]
        public string ERF085dL { get; set; }
        [Index(24)]
        public string ERFRSTRENG { get; set; }
        [Index(25)]
        public string RPRB31G { get; set; }
        [Index(26)]
        public string RPR085dL { get; set; }
        [Index(27)]
        public string RPRRSTRENG { get; set; }
        [Index(28)]
        public string PSafeB31G { get; set; }
        [Index(29)]
        public string PSafe085dL { get; set; }
        [Index(30)]
        public string PSafeRSTRENG { get; set; }
        [Index(31)]
        public string Comment { get; set; }
        [Index(32)]
        public double? Latitude { get; set; }
        [Index(33)]
        public double? Longitude { get; set; }
        [Index(34)]
        public double? Height_ft { get; set; }
        [Index(35)]
        public string BegEngSta { get; set; }
        [Index(36)]
        public string EndEngSta { get; set; }
        [Index(37)]
        public string BegAbsSta { get; set; }
        [Index(38)]
        public string EndAbsSta { get; set; }

        [Ignore]
        public string FeatureDescription { get => Event; set => throw new NotImplementedException(); }

        [Ignore]
        public double Odometer { get => Distance ??0; set => throw new NotImplementedException(); }

        [Ignore]
        public double? PipeLengthFT
        {
            get
            {
                double res = 0;
                double.TryParse(JointLengthft, out res);
                return res;
            }
            set
            {
                throw new Exception();
            }
        }

            [Ignore]
        public string FeatureType { get; set; }

        private double SetableDistancefromWeld = double.NaN;
        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                if (SetableDistancefromWeld != double.NaN)
                    return SetableDistancefromWeld;
                double res = 0;
                double.TryParse(USWeldDistance, out res);
                return Math.Abs(res);
            }
            set
            {
                SetableDistancefromWeld = value;
            }
        }

        [Ignore]
        public double MLLength
        {
            get
            {
                double res = 0;
                double.TryParse(Length_in, out res);
                return res;
            }
        }
    }

    public class xcollinsnew : IPipeDescription
    {
        [Index(0)]
        public string ILITool { get; set; }
        [Index(1)]
        public string AdjstdWeldNumberCDS { get; set; }
        [Index(2)]
        public string AdjstdApproxMilepostCDS { get; set; }
        [Index(3)]
        public string AdjstdApproxMapStationftCDS { get; set; }
        [Index(4)]
        public double? Odometerft { get; set; }
        [Index(5)]
        public string OdometerDistancetoStartofBoxft { get; set; }
        [Index(6)]
        public string FeatureNumber { get; set; }
        [Index(7)]
        public string _FeatureDescription { get; set; }
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
        public string LongSeamOrientDegrees { get; set; }
        [Index(23)]
        public string dot085DLB31GSafeMAOPRatingpsig { get; set; }
        [Index(24)]
        public string dot085DLB31GSafeMAOPRatingTolerancepsig { get; set; }
        [Index(25)]
        public string EffAreaSafeMAOPRatingpsig { get; set; }
        [Index(26)]
        public string EffAreaSafeMAOPRatingTolerancepsig { get; set; }
        [Index(27)]
        public string EffAreaBurstPressureRatingpsig { get; set; }
        [Index(28)]
        public string EffAreaBurstPressureRatingTolerancepsig { get; set; }
        [Index(29)]
        public string LatitudeNAD83 { get; set; }
        [Index(30)]
        public double? LongitudeNAD83 { get; set; }
        [Index(31)]
        public double? ElevationAboveMeanSeaLevelNAVD88ft { get; set; }
        [Index(32)]
        public string Comments { get; set; }
        [Index(33)]
        public string PipeSizein { get; set; }
        [Index(34)]
        public string PipeGrade { get; set; }
        [Index(35)]
        public string PipeType { get; set; }
        [Index(36)]
        public string MOPpsi { get; set; }


        [Ignore]
        public string FeatureDescription { get => _FeatureDescription; set => throw new NotImplementedException(); }

        [Ignore]
        public double Odometer { get => Odometerft ?? 0; set => throw new NotImplementedException(); }

        [Ignore]
        public double? PipeLengthFT
        {
            get
            {
                double res = 0;
                double.TryParse(PipeLengthft, out res);
                return res;
            }
            set { }
        }

        [Ignore]
        public string FeatureType { get; set; }

        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                double res = 0;
                double.TryParse(DistancetoUpstreamWeldft, out res);
                return Math.Abs(res);
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
    }
}