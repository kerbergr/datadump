using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace IlICompare
{
    public class OutputWriter
    {
        private int numOfSpaces;
        private Type type1;
        private Type type2;
        EmptySpace pt = new EmptySpace();
        public OutputWriter(  int Spaces = 0)
        {
            numOfSpaces = Spaces;
            //type1 = t1;
            //type2 = t2;
        }
        public void Write<T,T2>(string outputfile2, List<GenericOutput> output2) where T : new() where T2 : new()
        {
            using (var writer = new StreamWriter(outputfile2))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<MetaData>();
                csv.WriteHeader<T>();
                for(int i = 0; i < numOfSpaces; i++)
                {
                    csv.WriteHeader<EmptySpace>();
                }
                csv.WriteHeader<T2>();
                csv.NextRecord();
                foreach (var record in output2)
                {
                    csv.WriteRecord((MetaData)record.metaData);
                    if (record.leftData != null)
                    {
                        T output = (T)record.leftData;// as T2;
                        csv.WriteRecord(output);

                    }
                    else
                        csv.WriteRecord(new T());
                    for (int i = 0; i < numOfSpaces; i++)
                    {
                        csv.WriteRecord(pt);
                    }

                    if (record.rightData != null)
                    {
                        T2 output = (T2)record.rightData;// as T2;
                        csv.WriteRecord(output);

                    }
                    else
                        csv.WriteRecord(new T2());


                    csv.NextRecord();
                }
            }
        }

        public void Write(string outputfile2, List<SlimCombinedItems> output2) 
        {
            using (var writer = new StreamWriter(outputfile2))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<SlimCombinedItems>();
                csv.NextRecord();
                foreach (var record in output2)
                {
                    csv.WriteRecord(record);
                    csv.NextRecord();
                }
            }
        }
    }

   
}


   
