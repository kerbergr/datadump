namespace IlICompare
{
    public interface IMetaData
    {
        string Match { get; set; }
        double OdometerDifference { get; set; }
        int SizeDifference { get; set; }

        string MetalLossIdentifier { get; set; }
    }
}