using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MLCompare.UI.Form1;

namespace MLCompare.UI
{
    class ClassGenerator
    {
        public static string Property =

     @"[Index({0})]
        public {1} {2} { get; set; }
";

        public static string Property2 = @"[Index({0})]
public {1} {2} {{ get; set; }}
";

        public static string classdef = @"    public class {0} : IPipeDescription
    {{
";



        internal static string MakeClass(List<ColumnMetaData> columns, string classname)
        {

            String s = "";

            s += string.Format(classdef, classname);


            foreach (var item in columns)
            {
                string values = "string";

                var output = string.Format(Property2, item.index, item.VariableTypeString, item.variableName);
                s += output;
            }
            s += "}";
            return s;
        }



        internal static string MakeClass(string location)
        {
            String s = "";
            using (var reader = new StreamReader(location))
            {

                var csv = reader.ReadLine();


                var list = new List<string>();

                var listc = csv.Split(',');

                var fistline = reader.ReadLine();
                var listValues = fistline.Split(',');
                int i = 0;
                foreach (var item in listc)
                {
                    string values = "string";

                    if (i < listValues.Length)
                    {


                        var value = listValues[i];

                        double dd;
                        if (double.TryParse(value, out dd))
                        {
                            if (value.Contains("."))
                            {
                                values = "double ?";
                            }
                            else
                            {
                                value = "int ?";
                            }
                        }
                    }
                }
                return s;

            }
        }
    }
}


