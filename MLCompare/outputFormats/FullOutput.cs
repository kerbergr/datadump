using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class FullOutput : IOutput
    {

        [Index(0)]
        public string ItemNumber { get; set; }
        [Index(1)]
        public string JointNumber { get; set; }
        [Index(2)]
        public double? JointLengthft { get; set; }
        [Index(3)]
        public string DisttoUSGWft { get; set; }
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
        public string MOP { get; set; }
        [Index(19)]
        public string LongSeam { get; set; }
        [Index(20)]
        public string ERF { get; set; }
        [Index(21)]
        public string SafeBurstPressure { get; set; }
        [Index(22)]
        public string BurstPressure { get; set; }
        [Index(23)]
        public double? Latitudedeg { get; set; }
        [Index(24)]
        public double? Longitudedeg { get; set; }
        [Index(25)]
        public double? Elevationft { get; set; }




        [Index(26)]
        public string BHIIdentifier { get; set; }
        [Index(27)]
        public string PipelineFeature { get; set; }
        [Index(28)]
        public string INTEXTIDOD { get; set; }
        [Index(29)]
        public double? Odometerft { get; set; }
        [Index(30)]
        public double? DistancetoNextPipelineFeatureft { get; set; }
        [Index(31)]
        public double? newWTin { get; set; }
        [Index(32)]
        public string PipeGradepsi { get; set; }
        [Index(33)]
        public string PipeDescription { get; set; }
        [Index(34)]
        public double? PipeDiameterin { get; set; }
        [Index(35)]
        public string MOPpsi { get; set; }
        [Index(36)]
        public string newDepth { get; set; }
        [Index(37)]
        public string newDepthin { get; set; }
        [Index(38)]
        public string newLengthin { get; set; }
        [Index(39)]
        public string newWidthin { get; set; }
        [Index(40)]
        public string OClockOrientationhhmm { get; set; }
        [Index(41)]
        public string mB31GBurstpsi { get; set; }
        [Index(42)]
        public string newERF { get; set; }
        [Index(43)]
        public string EffDepth { get; set; }
        [Index(44)]
        public string EffLengthin { get; set; }
        [Index(45)]
        public string EffAreaBurstpsi { get; set; }
        [Index(46)]
        public string UpstreamUSReferenceName { get; set; }
        [Index(47)]
        public double? DistanceToUSft { get; set; }
        [Index(48)]
        public string DownstreamDSReferenceName { get; set; }
        [Index(49)]
        public double? DistanceFromDSReferenceft { get; set; }
        [Index(50)]
        public double? DistancetoUSWeldft { get; set; }
        [Index(51)]
        public double? DistancetoDSWeldft { get; set; }
        [Index(52)]
        public double? Length2ndUSJointft { get; set; }
        [Index(53)]
        public double? LengthUSJointft { get; set; }
        [Index(54)]
        public double? LengthDefectJointft { get; set; }
        [Index(55)]
        public string DefectJointNumber { get; set; }
        [Index(56)]
        public double? LengthDSJointft { get; set; }
        [Index(57)]
        public double? Length2ndDSJointft { get; set; }
        [Index(58)]
        public double? XYZInformationNAD83Latitude { get; set; }
        [Index(59)]
        public double? XYZInformationNAD83Longitude { get; set; }
        [Index(60)]
        public double? XYZInformationNAVD88Elevationft { get; set; }
        [Index(61)]
        public string newComments { get; set; }
        [Index(62)]
        public string MatchedAssurance { get; set; }
        public void SetMeta(IMetaData metaData)
        {
            MatchedAssurance = metaData?.Match;
        }

        void IOutput.SetLeft(IPipeDescription newILIItem)
        {
            var data = newILIItem as DataFrom2020;


            ItemNumber = data.ItemNumber;

            JointNumber = data.JointNumber;

            JointLengthft = data.JointLengthft;

            DisttoUSGWft = data.DisttoUSGWft;

            DisttoDSGWft = data.DisttoDSGWft;

            AbsoluteDistanceft = data.AbsoluteDistanceft;

            Feature = data.Feature;

            ExtInt = data.ExtInt;

            Depth = data.Depth;

            Depthin = data.Depthin;

            Lengthin = data.Lengthin;

            Widthin = data.Widthin;

            Oclockhhmm = data.Oclockhhmm;

            Comments = data.Comments;

            PipeType = data.PipeType;

            WTin = data.WTin;

            PipeGrade = data.PipeGrade;

            PipeODin = data.PipeODin;

            MOP = data.MOP;

            LongSeam = data.LongSeam;

            ERF = data.ERF;

            SafeBurstPressure = data.SafeBurstPressure;

            BurstPressure = data.BurstPressure;

            Latitudedeg = data.Latitudedeg;

            Longitudedeg = data.Longitudedeg;

            Elevationft = data.Elevationft;







   
        }

        void IOutput.SetRight(IPipeDescription oLDILIItem)
        {
            var data = oLDILIItem as Datafrom2018;


            BHIIdentifier = data.BHIIdentifier;

            PipelineFeature = data.PipelineFeature;

            INTEXTIDOD = data.INTEXTIDOD;

            Odometerft = data.Odometerft;

            DistancetoNextPipelineFeatureft = data.DistancetoNextPipelineFeatureft;

            newWTin = data.WTin;

            PipeGradepsi = data.PipeGradepsi;

            PipeDescription = data.PipeDescription;

            PipeDiameterin = data.PipeDiameterin;

            MOPpsi = data.MOPpsi;

            newDepth = data.Depth;

            newDepthin = data.Depthin;

            newLengthin = data.Lengthin;

            newWidthin = data.Widthin;

            OClockOrientationhhmm = data.OClockOrientationhhmm;

            mB31GBurstpsi = data.mB31GBurstpsi;

            newERF = data.ERF;

            EffDepth = data.EffDepth;

            EffLengthin = data.EffLengthin;

            EffAreaBurstpsi = data.EffAreaBurstpsi;

            UpstreamUSReferenceName = data.UpstreamUSReferenceName;

            DistanceToUSft = data.DistanceToUSft;

            DownstreamDSReferenceName = data.DownstreamDSReferenceName;

            DistanceFromDSReferenceft = data.DistanceFromDSReferenceft;

            DistancetoUSWeldft = data.DistancetoUSWeldft;

            DistancetoDSWeldft = data.DistancetoDSWeldft;

            Length2ndUSJointft = data.Length2ndUSJointft;

            LengthUSJointft = data.Length2ndUSJointft;

            LengthDefectJointft = data.LengthDefectJointft;

            DefectJointNumber = data.DefectJointNumber;

            LengthDSJointft = data.LengthDSJointft;

            Length2ndDSJointft = data.Length2ndDSJointft;

            XYZInformationNAD83Latitude = data.XYZInformationNAD83Latitude;

            XYZInformationNAD83Longitude = data.XYZInformationNAD83Longitude;

            XYZInformationNAVD88Elevationft = data.XYZInformationNAVD88Elevationft;

            newComments = data.Comments;
        }
    }
}