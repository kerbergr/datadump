namespace IlICompare
{
    public class GenericOutput : IOutput
    {
        public IPipeDescription leftData;
        public IMetaData metaData;
        public IPipeDescription rightData;

        public void SetLeft(IPipeDescription leftItem)
        {
            leftData = leftItem;
        }

        public void SetMeta(IMetaData metaData)
        {
            this.metaData = metaData;
        }

        public void SetRight(IPipeDescription rightitem)
        {
            rightData = rightitem;
        }

    }
}