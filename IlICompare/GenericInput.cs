using System;
using System.Collections.Generic;
using System.Text;

namespace IlICompare
{

    public class GenericInput : IPipeDescription
    {
        public GenericInput(ILIMetaData classDescription)
        {
            classdata = classDescription;
        }

        public void SetValues(List<string> valuez)
        {
            values = valuez;
        }

        public GenericInput()
        {

        }



        public List<string> values = new List<string>();
        private ILIMetaData classdata;
        private string _ft;

        public double DistanceFromWeld
        {
            get
            {
                double res = 0;
                double.TryParse( values[classdata.indexOfDistancefromWeld], out res);
                return res;
            }
            set
            {
                throw new Exception();
            }
        }
        public double MLLength
        {
            get
            {
                double res = 0;
                double.TryParse(values[classdata.indexOfMLLength], out res);
                return res;

            }
        }


        string IPipeDescription.FeatureDescription { get => values[classdata.indexOfDescription]; }
        double IPipeDescription.Odometer { get
            {
                {
                    double res = 0;
                    double.TryParse(values[classdata.indexOfOdometer], out res);
                    return res;
                }; 
            } 
        }

        double? IPipeDescription.PipeLengthFT
        {
            get
            {
                {
                    double res = 0;
                    double.TryParse(values[classdata.indexOfPipelineLength], out res);
                    return res;
                };
            }
        }
        public string FeatureType { get; set; }
    }
}
