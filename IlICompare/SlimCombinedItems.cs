using CsvHelper.Configuration.Attributes;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace IlICompare
{

    public class SlimCombinedItems : IOutput
    {
        [Index(0)]
        public string Odometer { get; set; }
        [Index(1)]
        public double? PipeLengthFT { get; set; }

        [Index(2)]
        public string FeatureDesc { get; set; }


        [Index(3)]
        public double? DistanceFromUP { get; set; }

        [Index(4)]
        public double? Length { get; set; }


        [Index(5)]
        public string oldDescription { get; set; }
       


        [Index(6)]
        public double? oldPipeLength { get; set; }


        [Index(7)]
        public string oldOdometer { get; set; }

        [Index(8)]
        public double? oldDistanceFromUpstreamWeld { get; set; }

        [Index(9)]
        public double? oldMLLength { get; set; }

        [Index(10)]
        public string MatchDescription { get; set; }



        void IOutput.SetLeft(IPipeDescription old)
        {
            Odometer = old.Odometer.ToString();

            PipeLengthFT = old.PipeLengthFT;
            FeatureDesc = old.FeatureDescription;
            Length = old.MLLength;
            DistanceFromUP = old.DistanceFromWeld;
        }

        void IOutput.SetRight(IPipeDescription newitem)
        {
            oldOdometer = newitem.Odometer.ToString();
            oldPipeLength = newitem.PipeLengthFT;
            oldDescription = newitem.FeatureDescription;
            oldMLLength = newitem.MLLength;
            oldDistanceFromUpstreamWeld = newitem.DistanceFromWeld;
        }

        public void SetMeta(IMetaData metaData)
        {
            MatchDescription = metaData?.MetalLossIdentifier;
        }
    }
}