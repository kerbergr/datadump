using CsvHelper.Configuration.Attributes;
using System;


namespace MLCompare
{
    public class CombinedItems
    {
        [Index(0)]
        public string Tool { get; set; }
        [Index(1)]
        public int? WeldNumber { get; set; }
        [Index(2)]
        public string ApproxMilePost { get; set; }
        [Index(3)]
        public string ApproxMapStation { get; set; }
        [Index(4)]
        public double? Odometer { get; set; }
        [Index(5)]
        public int? FeatureNumber { get; set; }
        [Index(6)]
        public string FeatureDescription { get; set; }
        [Index(7)]
        public string DistanceToNearestWeld { get; set; }
        [Index(8)]
        public double? DistanceToNearestUpstreamWeld { get; set; }
        [Index(9)]
        public double? DistanceToNearestDownStreamWeld { get; set; }
        [Index(10)]
        public string DistanceToNearestAGM { get; set; }
        [Index(11)]
        public double? DistanceToNearestUpstreamAGM { get; set; }
        [Index(12)]
        public double? DistanceToNearestDownStreamAGM { get; set; }
        [Index(13)]
        public double? WT { get; set; }
        [Index(14)]
        public double? MaxDepth { get; set; }
        [Index(15)]
        public string SeamWeldInteraction { get; set; }
        [Index(16)]
        public double? LengthInch { get; set; }
        [Index(17)]
        public double? WidthInch { get; set; }
        [Index(18)]
        public double? OrientationDegree { get; set; }
        [Index(19)]
        public double? PipeLengthFT { get; set; }
        [Index(20)]
        public string LongStemOrientationDegree { get; set; }
        [Index(21)]
        public string AdjacenttoLongSeam { get; set; }
        [Index(22)]
        public int? B31GMAOPRating { get; set; }
        [Index(23)]
        public int? EFFAreaMAOPRating { get; set; }
        [Index(24)]
        public int? EFFBurstPressRating { get; set; }
        [Index(25)]
        public int? MaxDepthTolerance { get; set; }
        [Index(26)]
        public int? B31GMAOPRatingWTolerance { get; set; }
        [Index(27)]
        public int? EFFAreaMAOPRatingWTolerance { get; set; }
        [Index(28)]
        public int? EFFBurstPressRatingWTolerance { get; set; }
        [Index(29)]
        public double? Latitude { get; set; }
        [Index(30)]
        public double? Longitude { get; set; }
        [Index(31)]
        public double? ElevationAboveSeaLevel { get; set; }
        [Index(32)]
        public string Comment { get; set; }
        [Index(33)]
        public string MultipleApexDent { get; set; }


        [Index(34)]
        public string newILITool { get; set; }
        [Index(35)]
        public int? newPipeJointNumber { get; set; }
        [Index(36)]
        public double? newApproxMilePost { get; set; }
        [Index(37)]
        public string newApproxMapStation { get; set; }
        [Index(38)]
        public double? newOdometer { get; set; }


        [Index(39)]
        public string newOdometerDistanceToPeakDepth { get; set; }
        [Index(40)]
        public int? newFeatureNumber { get; set; }
        [Index(41)]
        public string newFeatureDescription { get; set; }
        [Index(42)]
        public string newDistanceToNearestWeld { get; set; }
        [Index(43)]
        public double? newDistanceToNearestUpstreamWeld { get; set; }
        [Index(44)]
        public double? newDistanceToNearestDownStreamWeld { get; set; }
        [Index(45)]
        public string newDistanceToNearestAGM { get; set; }
        [Index(46)]
        public double? newDistanceToNearestUpstreamAGM { get; set; }
        [Index(47)]
        public double? newDistanceToNearestDownStreamAGM { get; set; }
        [Index(48)]
        public double? newWT { get; set; }
        [Index(49)]
        public double? newMaxDepth { get; set; }
        [Index(50)]
        public double? newLengthInch { get; set; }
        [Index(51)]
        public double? newWidthInch { get; set; }
        [Index(52)]
        public double? newOrientationDegree { get; set; }

        [Index(53)]
        public double? newOrientationPeakDepthDegree { get; set; }
        [Index(54)]
        public double? newPipeLengthFT { get; set; }

        [Index(55)]
        public string newLongStemOrientationDegree { get; set; }
        [Index(56)]
        public int? newo85DLSafeMAOPRating { get; set; }

        [Index(57)]
        public int? newEffAreaB31GAPI579MAOPRating { get; set; }
        [Index(58)]
        public int? newEffAreaB31GAPI579AreaBurstPressRating { get; set; }
        [Index(59)]
        public int? newMaxDepthTolerance { get; set; }
        [Index(60)]
        public int? newo85DLSafeMAOPRatingWTolerance { get; set; }
        [Index(61)]
        public int? newEffAreaB31GAPI579MAOPRatingWTolerance { get; set; }
        [Index(62)]
        public int? newEffAreaB31GAPI579AreaBurstPressRatingWTolerance { get; set; }
        [Index(63)]
        public double? newLatitude { get; set; }
        [Index(64)]
        public double? newLongitude { get; set; }
        [Index(65)]
        public double? newElevationAboveSeaLevel { get; set; }
        [Index(66)]
        public string newComment { get; set; }
        [Index(67)]
        public double? newPipeSize { get; set; }
        [Index(68)]
        public string newPipeGrade { get; set; }
        [Index(69)]
        public string newPipeType { get; set; }
        [Index(70)]
        public int? newMOP { get; set; }



        public void SetOld(OLDILIItem old)
        {
            Tool = old.Tool;
            WeldNumber = old.WeldNumber;
            ApproxMilePost = old.ApproxMilePost;
            ApproxMapStation = old.ApproxMapStation;
            Odometer = old.Odometer;
            FeatureNumber = old.FeatureNumber;
            FeatureDescription = old.FeatureDescription;
            DistanceToNearestWeld = old.DistanceToNearestWeld;
            DistanceToNearestUpstreamWeld = old.DistanceToNearestUpstreamWeld;
            DistanceToNearestDownStreamWeld = old.DistanceToNearestDownStreamWeld;
            DistanceToNearestAGM = old.DistanceToNearestAGM;
            DistanceToNearestUpstreamAGM = old.DistanceToNearestUpstreamAGM;
            DistanceToNearestDownStreamAGM = old.DistanceToNearestDownStreamAGM;
            WT = old.WT;
            MaxDepth = old.MaxDepth;
            SeamWeldInteraction = old.SeamWeldInteraction;
            LengthInch = old.LengthInch;
            WidthInch = old.WidthInch;
            OrientationDegree = old.OrientationDegree;
            PipeLengthFT = old.PipeLengthFT;
            LongStemOrientationDegree = old.LongStemOrientationDegree;
            AdjacenttoLongSeam = old.AdjacenttoLongSeam;
            B31GMAOPRating = old.B31GMAOPRating;
            EFFAreaMAOPRating = old.EFFAreaMAOPRating;
            EFFBurstPressRating = old.EFFBurstPressRating;
            MaxDepthTolerance = old.MaxDepthTolerance;
            B31GMAOPRatingWTolerance = old.B31GMAOPRatingWTolerance;
            EFFAreaMAOPRatingWTolerance = old.EFFAreaMAOPRatingWTolerance;
            EFFBurstPressRatingWTolerance = old.EFFBurstPressRatingWTolerance;
            Latitude = old.Latitude;
            Longitude = old.Longitude;
            ElevationAboveSeaLevel = old.ElevationAboveSeaLevel;
            Comment = old.Comment;
            MultipleApexDent = old.MultipleApexDent;
        }

        public void SetNew(NewILIItem newitem)
        {

            newILITool = newitem.ILITool;
            newPipeJointNumber = newitem.PipeJointNumber;
            newApproxMilePost = newitem.ApproxMilePost;
            newApproxMapStation = newitem.ApproxMapStation;
            newOdometer = newitem.Odometer;
            newOdometerDistanceToPeakDepth = newitem.OdometerDistanceToPeakDepth;
            newFeatureNumber = newitem.FeatureNumber;
            newFeatureDescription = newitem.FeatureDescription;
            newDistanceToNearestWeld = newitem.DistanceToNearestWeld;
            newDistanceToNearestUpstreamWeld = newitem.DistanceToNearestUpstreamWeld;
            newDistanceToNearestDownStreamWeld = newitem.DistanceToNearestDownStreamWeld;
            newDistanceToNearestAGM = newitem.DistanceToNearestAGM;
            newDistanceToNearestUpstreamAGM = newitem.DistanceToNearestUpstreamAGM;
            newDistanceToNearestDownStreamAGM = newitem.DistanceToNearestDownStreamAGM;
            newWT = newitem.WT;
            newMaxDepth = newitem.MaxDepth;
            newLengthInch = newitem.LengthInch;
            newWidthInch = newitem.WidthInch;
            newOrientationDegree = newitem.OrientationDegree;
            newOrientationPeakDepthDegree = newitem.OrientationPeakDepthDegree;
            newPipeLengthFT = newitem.PipeLengthFT;
            newLongStemOrientationDegree = newitem.LongStemOrientationDegree;
            newo85DLSafeMAOPRating = newitem.o85DLSafeMAOPRating;
            newEffAreaB31GAPI579MAOPRating = newitem.EffAreaB31GAPI579MAOPRating;
            newEffAreaB31GAPI579AreaBurstPressRating = newitem.EffAreaB31GAPI579AreaBurstPressRating;
            newMaxDepthTolerance = newitem.MaxDepthTolerance;
            newo85DLSafeMAOPRatingWTolerance = newitem.o85DLSafeMAOPRatingWTolerance;
            newEffAreaB31GAPI579MAOPRatingWTolerance = newitem.EffAreaB31GAPI579MAOPRatingWTolerance;
            newEffAreaB31GAPI579AreaBurstPressRatingWTolerance = newitem.EffAreaB31GAPI579AreaBurstPressRatingWTolerance;
            newLatitude = newitem.Latitude;
            newLongitude = newitem.Longitude;
            newElevationAboveSeaLevel = newitem.ElevationAboveSeaLevel;
            newComment = newitem.Comment;
            newPipeSize = newitem.PipeSize;
            newPipeGrade = newitem.PipeGrade;
            newPipeType = newitem.PipeType;
            newMOP = newitem.MOP;
        }


    }
}