using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class newHBtoNS : IPipeDescription
    {
        [Index(0)]
        public string ItemNumber { get; set; }
        [Index(1)]
        public string JointNumber { get; set; }
        [Index(2)]
        public double? JointLengthft { get; set; }
        [Index(3)]
        public double ? DisttoUSGWft { get; set; }
        [Index(4)]
        public double? DisttoDSGWft { get; set; }
        [Index(5)]
        public double? AbsoluteDistanceft { get; set; }
        [Index(6)]
        public string Feature { get; set; }
        [Index(7)]
        public string ExtInt { get; set; }
        [Index(8)]
        public string Depth { get; set; }
        [Index(9)]
        public string Depthin { get; set; }
        [Index(10)]
        public string Lengthin { get; set; }
        [Index(11)]
        public string Widthin { get; set; }
        [Index(12)]
        public string Oclockhhmm { get; set; }
        [Index(13)]
        public string Comments { get; set; }
        [Index(14)]
        public string PipeType { get; set; }
        [Index(15)]
        public string WTin { get; set; }
        [Index(16)]
        public string PipeGrade { get; set; }
        [Index(17)]
        public double? PipeODin { get; set; }
        [Index(18)]
        public string MOPpsi { get; set; }
        [Index(19)]
        public string LongSeam { get; set; }
        [Index(20)]
        public string ERF { get; set; }
        [Index(21)]
        public string SafeBurstPressurepsi { get; set; }
        [Index(22)]
        public string BurstPressurepsi { get; set; }
        [Index(23)]
        public double? Latitudedeg { get; set; }
        [Index(24)]
        public double? Longitudedeg { get; set; }
        [Index(25)]
        public double? Elevationft { get; set; }





        [Ignore]
        public string FeatureType { get; set; }


        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                return DisttoUSGWft ?? 0;
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
        string IPipeDescription.FeatureDescription { get => Feature;  }
        [Ignore] 
        double IPipeDescription.Odometer { get => AbsoluteDistanceft??0;  }
        [Ignore] 
        double? IPipeDescription.PipeLengthFT { get => JointLengthft;  }
    }

    public class new2022 : IPipeDescription
    {
        [Index(0)]
        public string ItemNumber { get; set; }
        [Index(1)]
        public string JointNumber { get; set; }
        [Index(2)]
        public double? JointLengthft { get; set; }
        [Index(3)]
        public double ? DisttoUSGWft { get; set; }
        [Index(4)]
        public double? DisttoDSGWft { get; set; }
        [Index(5)]
        public double? AbsoluteDistanceft { get; set; }
        [Index(6)]
        public string Feature { get; set; }
        [Index(7)]
        public string ExtInt { get; set; }
        [Index(8)]
        public string Depth { get; set; }
        [Index(9)]
        public string Depthin { get; set; }
        [Index(10)]
        public string Lengthin { get; set; }
        [Index(11)]
        public string Widthin { get; set; }
        [Index(12)]
        public string Oclockhhmm { get; set; }
        [Index(13)]
        public string Comments { get; set; }
        [Index(14)]
        public string PipeType { get; set; }
        [Index(15)]
        public string WTin { get; set; }
        [Index(16)]
        public string PipeGrade { get; set; }
        [Index(17)]
        public double? PipeODin { get; set; }
        [Index(18)]
        public string MOPpsi { get; set; }
        [Index(19)]
        public string LongSeam { get; set; }
        [Index(20)]
        public string ERF { get; set; }
        [Index(21)]
        public string SafeBurstPressurepsi { get; set; }
        [Index(22)]
        public string BurstPressurepsi { get; set; }
        [Index(23)]
        public string SafeBurstPressurepsi2 { get; set; }
        [Index(24)]
        public string BurstPressurepsi2 { get; set; }
        [Index(25)]
        public double? Latitudedeg { get; set; }
        [Index(26)]
        public double? Longitudedeg { get; set; }
        [Index(27)]
        public double? Elevationft { get; set; }






     [Ignore]
        public string FeatureType { get; set; }


        [Ignore]
        public double DistanceFromWeld
        {
            get
            {
                return DisttoUSGWft ?? 0;
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
        string IPipeDescription.FeatureDescription { get => Feature; }
        [Ignore]
        double IPipeDescription.Odometer { get => AbsoluteDistanceft ?? 0; }
        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => JointLengthft; }
    }


    public class oldfrom2022 : IPipeDescription
    {

        [Index(0)]
        public string FeatureNumbersequentialorder { get; set; }
        [Index(1)]
        public string PipelineFeature { get; set; }
        [Index(2)]
        public string INTEXTIDOD { get; set; }
        [Index(3)]
        public double? Odometer { get; set; }
        [Index(4)]
        public string StationNumber { get; set; }
        [Index(5)]
        public double? DistancetoUSweld { get; set; }
        [Index(6)]
        public double? DistancetoDSweld { get; set; }
        [Index(7)]
        public double? JointLength { get; set; }
        [Index(8)]
        public string DefectJointNumber { get; set; }
        [Index(9)]
        public string UpstreamUSReferenceName { get; set; }
        [Index(10)]
        public string UpStreamDistanceFrom { get; set; }
        [Index(11)]
        public string DownstreamName { get; set; }
        [Index(12)]
        public double? DownstreamDistanceTo { get; set; }
        [Index(13)]
        public double? Diameter { get; set; }
        [Index(14)]
        public double? NominalWallThickness { get; set; }
        [Index(15)]
        public string MeasuredWallThickness { get; set; }
        [Index(16)]
        public string PipeGradeSMYS { get; set; }
        [Index(17)]
        public string LongSeamOrientation { get; set; }
        [Index(18)]
        public string MetalLossDepth { get; set; }
        [Index(19)]
        public string MetalLossDepth2 { get; set; }
        [Index(20)]
        public string DeformationDepth { get; set; }
        [Index(21)]
        public string DeformationDepth2 { get; set; }
        [Index(22)]
        public string CrackDepth { get; set; }
        [Index(23)]
        public string CrackDepth2 { get; set; }
        [Index(24)]
        public string Length { get; set; }
        [Index(25)]
        public string Width { get; set; }
        [Index(26)]
        public string Orientation { get; set; }
        [Index(27)]
        public string MOP { get; set; }
        [Index(28)]
        public string ModifiedB31GPBURST { get; set; }
        [Index(29)]
        public string ModifiedB31GPSAFE { get; set; }
        [Index(30)]
        public string DesignPressure72SMYS { get; set; }
        [Index(31)]
        public string ERF_MOP_SAFE { get; set; }
        [Index(32)]
        public string RPR_PBURST_100_SMYS { get; set; }
        [Index(33)]
        public string EffectiveAreaPBurst { get; set; }
        [Index(34)]
        public string EffectiveAreaPSafe { get; set; }
        [Index(35)]
        public string GroupNumber { get; set; }
        [Index(36)]
        public string GroupCategory { get; set; }
        [Index(37)]
        public string NAD83Latitude { get; set; }
        [Index(38)]
        public string NAD83Longitude { get; set; }
        [Index(39)]
        public string NAVD88 { get; set; }
        [Index(40)]
        public string Comments { get; set; }
        [Index(41)]
        public string POFClassification { get; set; }
        [Index(42)]
        public string ExcavationRepairRequired { get; set; }
        [Index(43)]
        public string SPLCNotes { get; set; }
        [Index(44)]
        public string ToolTypeTechnology { get; set; }
        [Index(45)]
        public string LengthAx { get; set; }
        [Index(46)]
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
        string IPipeDescription.FeatureDescription { get => PipelineFeature; }
        [Ignore]
        double IPipeDescription.Odometer { get => Odometer ?? 0; }
        [Ignore]
        double? IPipeDescription.PipeLengthFT { get => JointLength; }
    }


}