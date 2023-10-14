using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class oldfeb2023 : IPipeDescription
    {

        [Index(0)]
public string FeatureID { get; set; }
[Index(1)]
public string SegmentIdentifier { get; set; }
[Index(2)]
public string AssessmentYear { get; set; }
[Index(3)]
public string ToolType { get; set; }
[Index(4)]
public string UpstreamReferenceGirthWeld { get; set; }
[Index(5)]
public string DistancetoUpstreamGirthWeld { get; set; }
[Index(6)]
public double ? AbsoluteDistance { get; set; }
[Index(7)]
public double ? DistancetoDownstreamGirthWeld { get; set; }
[Index(8)]
public string FeatureType_fromSheet { get; set; }
[Index(9)]
public string FeatureIdentification { get; set; }
[Index(10)]
public string SurfaceLocation { get; set; }
[Index(11)]
public string Comment { get; set; }
[Index(12)]
public string FeatureOrientation { get; set; }
[Index(13)]
public string PeakDepthofCorrosionorCrackAnomaly { get; set; }
[Index(14)]
public string PeakDepthofDentAnomaly { get; set; }
[Index(15)]
public string LengthofAnomaly { get; set; }
[Index(16)]
public string WidthofAnomaly { get; set; }
[Index(17)]
public string Psafe { get; set; }
[Index(18)]
public string Pburst { get; set; }
[Index(19)]
public string PburstMAOP { get; set; }
[Index(20)]
public string HalfLifeCorrosionGrowthRate { get; set; }
[Index(21)]
public string BendRadius { get; set; }
[Index(22)]
public string LongSeamOrientation { get; set; }
[Index(23)]
public double ? FeatureMilepost { get; set; }
[Index(24)]
public string HCA { get; set; }
[Index(25)]
public string MAOP { get; set; }
[Index(26)]
public double ? PipeOD { get; set; }
[Index(27)]
public double ? PipeWallThickness { get; set; }
[Index(28)]
public string SMYS { get; set; }
[Index(29)]
public string _100SMYS { get; set; }
[Index(30)]
public double ? MaximumOperatingStress { get; set; }
[Index(31)]
public double ? SafetyFactorforOriginalDOTDesignClassLocation { get; set; }
[Index(32)]
public string InstallationYear { get; set; }
[Index(33)]
public string ActualToolSpeed { get; set; }
[Index(34)]
public string MaximumAllowableToolSpeed { get; set; }
[Index(35)]
public string ILIVendor { get; set; }
[Index(36)]
public string ToolRunDate { get; set; }
[Index(37)]
public double ? DistancefromUpstreamGirthWeldtoUpstreamReference { get; set; }
[Index(38)]
public double ? DistancefromUpstreamGirthWeldtoDownstreamReference { get; set; }
[Index(39)]
public string UpstreamReferenceDescription { get; set; }
[Index(40)]
public string DownstreamReferenceDescription { get; set; }
[Index(41)]
public string Latitude { get; set; }
[Index(42)]
public string Longitude { get; set; }
[Index(43)]
        public string ZCoordinate { get; set; }


        [Ignore]
        public string FeatureDescription { get => FeatureIdentification; set => throw new NotImplementedException(); }

        [Ignore]
        public double Odometer { get => AbsoluteDistance ?? 0; set => throw new NotImplementedException(); }

        [Ignore]
        public double? PipeLengthFT
        {
            get
            {
                double res = 0;
                double.TryParse(DistancetoUpstreamGirthWeld, out res);
                return res + DistancetoDownstreamGirthWeld;
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
                double.TryParse(DistancetoUpstreamGirthWeld, out res);
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
                double.TryParse(WidthofAnomaly, out res);
                return res;
            }
        }
    }


    public class oldApril2023 : IPipeDescription
    {

        [Index(0)]
        public string FeatureID { get; set; }
        [Index(1)]
        public string SegmentIdentifier { get; set; }
        [Index(2)]
        public string AssessmentYear { get; set; }
        [Index(3)]
        public string ToolType { get; set; }
        [Index(4)]
        public string UpstreamReferenceGirthWeld { get; set; }
        [Index(5)]
        public string DistancetoUpstreamGirthWeld { get; set; }
        [Index(6)]
        public double? AbsoluteDistance { get; set; }
        [Index(7)]
        public string DistancetoDownstreamGirthWeld { get; set; }
        [Index(8)]
        public string FeatureType_fromSheet { get; set; }
        [Index(9)]
        public string FeatureIdentification { get; set; }
        [Index(10)]
        public string SurfaceLocation { get; set; }
        [Index(11)]
        public string _2023 { get; set; }
        [Index(12)]
        public string Comment { get; set; }
        [Index(13)]
        public string FeatureOrientation { get; set; }
        [Index(14)]
        public string PeakDepthofCorrosionorCrackAnomaly { get; set; }
        [Index(15)]
        public string PeakDepthofDentAnomaly { get; set; }
        [Index(16)]
        public string LengthofAnomaly { get; set; }
        [Index(17)]
        public string WidthofAnomaly { get; set; }
        [Index(18)]
        public string Psafe { get; set; }
        [Index(19)]
        public string Pburst { get; set; }
        [Index(20)]
        public string PburstMAOP { get; set; }
        [Index(21)]
        public string HalfLifeCorrosionGrowthRate { get; set; }
        [Index(22)]
        public string BendRadius { get; set; }
        [Index(23)]
        public string LongSeamOrientation { get; set; }
        [Index(24)]
        public string Milepost { get; set; }
        [Index(25)]
        public string Stationing { get; set; }
        [Index(26)]
        public string HCA { get; set; }
        [Index(27)]
        public string MAOP { get; set; }
        [Index(28)]
        public string PipeOD { get; set; }
        [Index(29)]
        public string PipeWallThickness { get; set; }
        [Index(30)]
        public string SMYS { get; set; }
        [Index(31)]
        public string _100SMYS { get; set; }
    [Index(32)]
    public string MaximumOperatingStress { get; set; }
    [Index(33)]
    public string SafetyFactorforOriginalDesignClassLocation { get; set; }
    [Index(34)]
    public string InstallationYear { get; set; }
    [Index(35)]
    public string ActualToolSpeed { get; set; }
    [Index(36)]
    public double? MaximumAllowableToolSpeed { get; set; }
    [Index(37)]
    public string ILIVendor { get; set; }
    [Index(38)]
    public string ToolRunDate { get; set; }
    [Index(39)]
    public string DistancefromUpstreamGirthWeldtoUpstreamReference { get; set; }
    [Index(40)]
    public string DistancefromUpstreamGirthWeldtoDownstreamReference { get; set; }
    [Index(41)]
    public string UpstreamReferenceDescription { get; set; }
    [Index(42)]
    public string DownstreamReferenceDescription { get; set; }
    [Index(43)]
    public double? Latitude { get; set; }
    [Index(44)]
    public double? Longitude { get; set; }
    [Index(45)]
    public double? Zcoordinte { get; set; }



    [Ignore]
        public string FeatureDescription { get => FeatureIdentification; set => throw new NotImplementedException(); }

        [Ignore]
        public double Odometer { get => AbsoluteDistance ?? 0; set => throw new NotImplementedException(); }

        [Ignore]
        public double? PipeLengthFT
        {
            get
            {
                double res = 0;
                double.TryParse(DistancetoUpstreamGirthWeld, out res);

                double res2 = 0;
                double.TryParse(DistancetoDownstreamGirthWeld, out res2);
                return res + res2;
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
                double.TryParse(DistancetoUpstreamGirthWeld, out res);
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
                double.TryParse(WidthofAnomaly, out res);
                return res;
            }
        }
    }



    public class newfeb2023 : IPipeDescription
    {
        [Index(0)]
        public string FeatureID { get; set; }
        [Index(1)]
        public string SegmentIdentifier { get; set; }
        [Index(2)]
        public string AssessmentYear { get; set; }
        [Index(3)]
        public string ToolType { get; set; }
        [Index(4)]
        public string UpstreamReferenceGirthWeld { get; set; }
        [Index(5)]
        public double ? DistancetoUpstreamGirthWeld { get; set; }
        [Index(6)]
        public double? AbsoluteDistance { get; set; }
        [Index(7)]
        public double? DistancetoDownstreamGirthWeld { get; set; }
        [Index(8)]
        public string ClusterNumber { get; set; }
        [Index(9)]
        public string FeatureType_fromSheet { get; set; }
        [Index(10)]
        public string FeatureIdentification { get; set; }
        [Index(11)]
        public string SurfaceLocation { get; set; }
        [Index(12)]
        public string Comment { get; set; }
        [Index(13)]
        public string FeatureOrientation { get; set; }
        [Index(14)]
        public string PeakDepthofMetalLossorCrackAnomaly { get; set; }
        [Index(15)]
        public string PeakDepthofDentorDeformationAnomaly { get; set; }
        [Index(16)]
        public string LengthofAnomaly { get; set; }
        [Index(17)]
        public string WidthofAnomaly { get; set; }
        [Index(18)]
        public string B31GPburst { get; set; }
        [Index(19)]
        public string B31GPburstMAOP { get; set; }
        [Index(20)]
        public string ModB31GPburst { get; set; }
        [Index(21)]
        public string ModB31GPburstMAOP { get; set; }
        [Index(22)]
        public string EffectAreaPburst { get; set; }
        [Index(23)]
        public string EffectAreaPburstMAOP { get; set; }
        [Index(24)]
        public string HalfLifeCorrosionGrowthRate { get; set; }
        [Index(25)]
        public string BendRadius { get; set; }
        [Index(26)]
        public string LongSeamOrientation { get; set; }
        [Index(27)]
        public double? BoreDiameter { get; set; }
        [Index(28)]
        public double? Milepost { get; set; }
        [Index(29)]
        public string HCA { get; set; }
        [Index(30)]
        public string MAOP { get; set; }
        [Index(31)]
        public double? PipeOD { get; set; }
        [Index(32)]
        public double? PipeWallThicknessNOMINAL { get; set; }
        [Index(33)]
        public string PipeWallThicknessMEASURED { get; set; }
        [Index(34)]
        public string SMYS { get; set; }
        [Index(35)]
        public string _100SMYS { get; set; }
    [Index(36)]
    public string MaximumOperatingStress { get; set; }
    [Index(37)]
    public string SafetyFactorforOriginalDesignClassLocation { get; set; }
    [Index(38)]
    public string InstallationYear { get; set; }
    [Index(39)]
    public double? ActualToolSpeed { get; set; }
    [Index(40)]
    public string MaximumAllowableToolSpeed { get; set; }
    [Index(41)]
    public string ILIVendor { get; set; }
    [Index(42)]
    public string ToolRunDate { get; set; }
    [Index(43)]
    public string DistancefromUpstreamGirthWeldtoUpstreamReference { get; set; }
    [Index(44)]
    public double? DistancefromUpstreamGirthWeldtoDownstreamReference { get; set; }
    [Index(45)]
    public string UpstreamReferenceDescription { get; set; }
    [Index(46)]
    public string DownstreamReferenceDescription { get; set; }
    [Index(47)]
    public double? Latitude { get; set; }
    [Index(48)]
    public double? Longitude { get; set; }
    [Index(49)]
    public double? Zcoordinate { get; set; }
    [Index(50)]
    public string PsafeB31Gpsi { get; set; }
    [Index(51)]
    public string PsafeMB31Gpsi { get; set; }
    [Index(52)]
    public string PsafeEA31Gpsi { get; set; }



    [Ignore]
        public string FeatureDescription { get => FeatureIdentification; set => throw new NotImplementedException(); }

        [Ignore]
        public double Odometer { get => AbsoluteDistance ?? 0; set => throw new NotImplementedException(); }

        [Ignore]
        public double? PipeLengthFT
        {
            get
            {
                return DistancetoUpstreamGirthWeld + DistancetoDownstreamGirthWeld;
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
                return DistancetoUpstreamGirthWeld ?? 1;
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
                double.TryParse(WidthofAnomaly, out res);
                return res;
            }
        }
    }

}