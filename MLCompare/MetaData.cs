using CsvHelper.Configuration.Attributes;

namespace MLCompare
{
    public class MetaData : IMetaData
    {
        [Index(0)]
        public string Match { get; set; }


        [Index(1)]
        public string Type { get; set; }

        [Index(2)]
        public string MetalLossIdentifier { get; set; } = "";

        [Ignore]
        public double OdometerDifference { get;  set; }
        [Ignore]
        public int SizeDifference { get;  set; }

        public MetaData clone()
        {
            return new MetaData() { Match = this.Match, Type = this.Type, MetalLossIdentifier = this.MetalLossIdentifier };
        }
    }
}