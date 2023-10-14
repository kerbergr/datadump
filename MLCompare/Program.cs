using System;
using System.Linq;
using CsvHelper.Configuration.Attributes;
using NUnit.Framework;
 
namespace MLCompare
{
    class Program
    {
        static void Main(string[] args)
        {

            //var rightReaderObject = IlICompare.InputReaderOpenXML.GetColumnsData("");

            //rightReaderObject.indexOfDescription = rightReaderObject.columnNames.First(x => x.isFeatureDescription).index;
            //rightReaderObject.indexOfDistancefromWeld = rightReaderObject.columnNames.First(x => x.isDistanceFromWeld).index;
            //rightReaderObject.indexOfMLLength = rightReaderObject.columnNames.First(x => x.isMLLength).index;
            //rightReaderObject.indexOfOdometer = rightReaderObject.columnNames.First(x => x.isOdometer).index;
            //rightReaderObject.indexOfPipelineLength = rightReaderObject.columnNames.First(x => x.isPipelength).index;


            //var output = InputReaderOpenXML.ReadPipesplz(rightReaderObject, rightReaderObject.FileLocation);



            Console.WriteLine("Hello World!");


            //InputReader.GetData("examples\\X-Collins - New ILI.csv");


            var leftFile = "ex2023\\april_New_ILI.csv";
            var rightFile = "ex2023\\april_Old_ILI.csv";

             var newcode = ClassMaker.MakeClass(leftFile);

            var oldcode  =ClassMaker.MakeClass(rightFile);




            //if we parse the list down run thi
            //newiliList = newiliList.Where(x => x.FeatureDescription.ToLower().Contains("weld") || x.FeatureDescription.ToLower().Contains("ml")).ToList();

            var details = new PipeDetails();

            var pipefeatures = InputReader.ReadPipes<newfeb2023>(leftFile, false);
            var leftPipes = details.TurnFeaturesIntoPipes(pipefeatures);


            var count = leftPipes.Sum(x => x.PipesItems.Count);

            var pipefeaturesR = InputReader.ReadPipes<oldApril2023>(rightFile, false);
            var rightPipes = details.TurnFeaturesIntoPipes(pipefeaturesR,false);


            //these are for old data
            details.FirstLeft = 55.42;
            details.FirstRight = 55.2;
            details.AddBoth(leftPipes, rightPipes);
            details.SquashList();

           // leftPipes.RemoveAt(0);
            //leftPipes.RemoveAt(0);
            //leftPipes.RemoveAt(0);
            //leftPipes.RemoveAt(0);

            //rightPipes.RemoveAt(0);

            //details.JustSquashPipes(leftPipes, rightPipes); ;

            var courjdtnt = details.Pipes.Sum(c => c?.Right?.PipesItems?.Count ?? 0);

            var outputWriter = new OutputWriter(1);



            var output = details.FullOutputWithFeatureMatchingFromLeftSide<GenericOutput>().ToList();
            outputWriter.Write<newfeb2023, oldApril2023>("LeftFirst\\ls_new_FullOutput.csv", output);
            var output2 = details.FullOutputWithFeatureMatchingFromLeftSide<SlimCombinedItems>().ToList();
            Assert.AreEqual(output.Count, output2.Count);
            outputWriter.Write("LeftFirst\\ls_new_SlimmedOutput.csv", output2);


            output = details.FullOutputWithFeatureMatching<GenericOutput>(false, true,true).ToList();
            outputWriter.Write<newfeb2023, oldApril2023>("LeftFirst\\lf_FullOutput.csv", output);
            output2 = details.FullOutputWithFeatureMatching<SlimCombinedItems>(false,true,true).ToList();
            Assert.AreEqual(output.Count, output2.Count);
            outputWriter.Write("LeftFirst\\lf_SlimmedOutput.csv", output2);



            output = details.FullOutputWithFeatureMatching<GenericOutput>(false, true, false).ToList();
            outputWriter.Write<newfeb2023, oldApril2023>("OdometerFirst\\of_FullOutput.csv", output);
            output2 = details.FullOutputWithFeatureMatching<SlimCombinedItems>(false, true, false).ToList();
            Assert.AreEqual(output.Count, output2.Count);
            outputWriter.Write("OdometerFirst\\of_SlimmedOutput.csv", output2);




            output = details.FullOutputWithFeatureMatchingFromLeftSide<GenericOutput>().ToList();
            outputWriter.Write<newfeb2023, oldApril2023>("LeftFirst\\ls_new_FullOutput.csv", output);
            output2 = details.FullOutputWithFeatureMatchingFromLeftSide<SlimCombinedItems>().ToList();
            Assert.AreEqual(output.Count, output2.Count);
            outputWriter.Write("LeftFirst\\ls_new_SlimmedOutput.csv", output2);
        }


    }

   
}


   
