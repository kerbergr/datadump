using CsvHelper.Configuration;

namespace MLCompare
{
    public class AllFields : IOutput
    {
        public DataFrom2020 RightItem { get; private set; }
        public Datafrom2018 LeftItem { get; private set; }

        public void SetLeft(IPipeDescription newILIItem)
        {
            LeftItem = newILIItem as Datafrom2018;
        }

        public void SetMeta(IMetaData metaData)
        {
            throw new System.NotImplementedException();
        }

        public void SetRight(IPipeDescription oLDILIItem)
        {
            RightItem = oLDILIItem as DataFrom2020;
        }
    }
    public class AllFieldsMapper : ClassMap<AllFields>
    {


        public AllFieldsMapper()
        {
           // var 
            //Map(member=>member.LeftItem.)
        }

    }
}