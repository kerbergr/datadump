using System;
using System.Collections.Generic;
using System.IO;

namespace MLCompare
{
    internal class ClassMaker
    {


        public static string Property =

        @"[Index({0})]
        public {1} {2} { get; set; }
";

        public static string Property2 = @"[Index({0})]
public {1} {2} {{ get; set; }}
";



      
        internal static string MakeClass(string location)
        {
            String s = "";
            string e = "";
            using (var reader = new StreamReader(location))
            {

                var csv = reader.ReadLine();


                var list = new List<string>();

                var listc = csv.Split(",");

                var fistline = reader.ReadLine();
                var listValues = fistline.Split(",");
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

                    var name = item.Replace(" ", "");
                    name = name.Replace("(", "");
                    name = name.Replace(")", "");
                    name = name.Replace("+", "");
                    name = name.Replace(".", "");
                    name = name.Replace("/", "");
                    name = name.Replace("%", "");
                    name = name.Replace("\"" , "");
                    name = name.Replace("'", "");
                    name = name.Replace("°", "");
                    name = name.Replace("[", "");
                    name = name.Replace("]", "");
                    var output = string.Format(Property2, i, values, name);
                    s += output;
                    i++;
                  
                }
            }
            return s;
          
        }
    }
}