namespace MLCompare
{
    public interface IMetaData
    {
        string Match { get; set; }
        public double OdometerDifference { get; set; }
        public int SizeDifference { get; set; }

        public string MetalLossIdentifier { get; set; }
    }
}