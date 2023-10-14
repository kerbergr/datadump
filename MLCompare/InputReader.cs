
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Microsoft.Office.Interop.Excel;

namespace MLCompare
{
    public static class InputReader
    {
        public static List<IPipeDescription> ReadPipes<T>(string fileLocation, bool OnlyReadMetalLossAndWelds = false)
        {
            var OLDILIItemList = new List<IPipeDescription>();
            using (var reader = new StreamReader(fileLocation))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                var oututs = csv.GetRecords<T>().ToList();

                OLDILIItemList = oututs.Cast<IPipeDescription>().ToList();

            }

            if (OnlyReadMetalLossAndWelds)
                OLDILIItemList = OLDILIItemList.Where(x => x.FeatureDescription.ToLower().Contains("weld") || x.FeatureDescription.ToLower().Contains("metal")).ToList();

            List<Pipe> oldPipes = new List<Pipe>() { new Pipe() };
            foreach (var old in OLDILIItemList)
            {
                old.FeatureType = PipeDetails.StringToType(old.FeatureDescription);
                if (old.FeatureDescription.ToLower().Contains("weld"))
                {
                    var pipe = new Pipe();
                    pipe.Odometer = old.Odometer;
                    pipe.Pipelength = old.PipeLengthFT ?? 0;
                    oldPipes.Add(pipe);
                }

                oldPipes[oldPipes.Count - 1].AddPipeFeature(old);
            }
            return OLDILIItemList;

        }


        public static List<GenericInput> ReadPipesplz(string fileLocation , ILIMetaData howToReadThem)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open(fileLocation);
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[1];
            List<GenericInput> list = new List<GenericInput>();
           int j = 2;
            while (true)
            {
                Range row = (Range)xlWorkSheet.Rows[j];
                var GenericInput = new GenericInput(howToReadThem);
                for (int i = 1; i <= howToReadThem.columnNames.Count; i++)
                {
                    Range cell = (Range)row.Cells[1, i];
                    var value = cell.Value;
                    if (value ==null)
                        GenericInput.values.Add(null);
                    else
                        GenericInput.values.Add(value.ToString());
                }
                list.Add(GenericInput);
            }

      



            return null;

        }



        public static ILIMetaData GetData(string filename)
        {
            ILIMetaData data = new ILIMetaData();

            var excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open(filename);
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[1];
            Range row = (Range)xlWorkSheet.Rows[1];
            int max = 100;
            for (int i = 1; i <= max; i++)
            {

                Range cell = (Range)row.Cells[1, i];
                var value = cell.Value;
                if (value != null)
                    data.columnNames.Add(new ColumnMetaData(value, i - 0));

            }



            wb.Save();
            wb.Close();
            return data;


        }
    }

  


}


   
