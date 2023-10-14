using CsvHelper.Configuration.Attributes;

namespace IlICompare
{
    public class EmptySpace
    {
        [Index(0)]
        public string Empty { get; set; } = "";

    }
}