using System;
using System.Collections.Generic;
using System.Linq;


namespace IlICompare
{
    internal class PipeDetails
    {

        public List<T> FullOutput<T>() where T : IOutput, new()
        {
            var list = new List<T>();

            foreach (var item in Pipes)
            {

                T outp = new T();





                //list.Add(outp);
                for (int i = 0; i < (item?.Left?.PipesItems?.Count ?? 0); i++)
                {
                    IPipeDescription old1 = (IPipeDescription)item.Left.PipesItems[i];
                    var outp2 = new T();
                    outp2.SetLeft(old1 as IPipeDescription);
                    if (i < (item?.Right?.PipesItems.Count ?? 0))
                    {
                        IPipeDescription new1 = (IPipeDescription)item.Right.PipesItems[i];
                        outp2.SetRight(new1 as IPipeDescription);
                    }
                    outp2.SetMeta(item.CombinedPipeMetaData);
                    list.Add(outp2);

                }

                for (int i = (item?.Left?.PipesItems?.Count ?? 0); i < (item?.Right?.PipesItems?.Count ?? 0); i++)
                {
                    var outp2 = new T();
                    IPipeDescription new1 = (IPipeDescription)item.Right.PipesItems[i];
                    outp2.SetRight(new1 as IPipeDescription);
                    outp2.SetMeta(item.CombinedPipeMetaData);
                    list.Add(outp2);
                }

            }
            return list;
        }




        public List<T> FullOutputWithFeatureMatchingFromLeftSide<T>() where T : IOutput, new()
        {
            var list = new List<T>();


            foreach (var item in Pipes)
            {
                var LeftItems = item?.Left?.PipesItems.ToList() ?? new List<IPipeDescription>();
                var rightItems = item?.Right?.PipesItems.ToList() ?? new List<IPipeDescription>();
                T outp = new T();

                int i = 0;
                int j = 0;
                double multiplyLbyThisToGetR = 1;
                double leftPipelength = 0;
                double RightPipelength = 0;




                foreach (var left in LeftItems)
                {
                    IPipeDescription foundRight = null;
                    double bestAbsDiff = 89127489;
                    if (left.Odometer > 656120)
                        Console.WriteLine("HI");

                    var itemsToadd = new List<IPipeDescription>();


                    foreach (var right in rightItems)
                    {
                        if (left?.FeatureType == Weld && right?.FeatureType == Weld)
                        {
                            leftPipelength = left.PipeLengthFT ?? 0;
                            RightPipelength = right.PipeLengthFT ?? 0;
                            multiplyLbyThisToGetR = RightPipelength / leftPipelength;
                            foundRight = right;
                            itemsToadd.Add(right);
                            break;
                        }

                        //IPipeDescription prefectmatch = FindThePerfectMatch(rightItems, left, ref j, multiplyLbyThisToGetR);

                        var trueStart = left.DistanceFromWeld * multiplyLbyThisToGetR;


                        var diff = (right.DistanceFromWeld - trueStart);
                        var value = Math.Abs(diff);
                        if (value < tolerance && left?.FeatureType == right?.FeatureType)
                        {
                            if (value < bestAbsDiff)
                            {
                                foundRight = right;
                                bestAbsDiff = value;
                                itemsToadd.Add(right);
                                continue;
                            }
                        }
                        if (diff < 0)
                        {
                            itemsToadd.Add(right);
                        }

                    }


                    foreach (var rightitem in itemsToadd)
                    {
                        var outp2 = new T();
                        var meta = new MetaData();
                        outp2.SetRight(rightitem as IPipeDescription);
                        if (foundRight == rightitem)
                        {
                            outp2.SetLeft(left as IPipeDescription);
                            meta.MetalLossIdentifier = $"Feature match tolerance={tolerance}, diff={bestAbsDiff}";
                        }
                        else
                        {
                            meta.MetalLossIdentifier = "Right Only";
                        }
                        if (left?.FeatureType == Weld)
                            meta.MetalLossIdentifier = item.CombinedPipeMetaData.Match;
                        outp2.SetMeta(meta);
                        list.Add(outp2);
                        rightItems.Remove(rightitem);
                    }
                    if (foundRight == null)
                    {
                        var outp2 = new T();
                        var meta = new MetaData();
                        outp2.SetLeft(left as IPipeDescription);
                        meta.MetalLossIdentifier = "Left Only";
                        outp2.SetMeta(meta);
                        list.Add(outp2);
                    }

                }
                foreach (var rightitem in rightItems)
                {
                    var outp2 = new T();
                    var meta = new MetaData();
                    outp2.SetRight(rightitem as IPipeDescription);
                    meta.MetalLossIdentifier = "Right Only";
                    outp2.SetMeta(meta);
                    list.Add(outp2);
                }

            }
            return list;
        }



        public List<T> FullOutputWithFeatureMatching<T>(bool CopyManyToOnes = false, bool JustMatchOne = false, bool DoLeftSideFirst = false) where T : IOutput, new()
        {
            var list = new List<T>();


            foreach (var item in Pipes)
            {
                var LeftItems = item?.Left?.PipesItems ?? new List<IPipeDescription>();
                var rightItems = item?.Right?.PipesItems ?? new List<IPipeDescription>();
                T outp = new T();

                int i = 0;
                int j = 0;

                double leftPipelength = 0;
                double RightPipelength = 0;
                double multiplyLbyThisToGetR = 1;
                List<int> listOfTakenIndexs = new List<int>();

                while (i < LeftItems.Count || j < rightItems.Count)
                {
                    var left = LeftItems.ElementAtOrDefault(i);
                    var right = rightItems.ElementAtOrDefault(j);
                    if (left?.FeatureType == Weld && right?.FeatureType == Weld)
                    {
                        var wout = new T();
                        var meta = new MetaData();
                        meta.MetalLossIdentifier = "Weld";
                        leftPipelength = left.PipeLengthFT ?? 0;
                        RightPipelength = right.PipeLengthFT ?? 0;
                        multiplyLbyThisToGetR = RightPipelength / leftPipelength;
                        wout.SetRight(right as IPipeDescription);
                        wout.SetLeft(left as IPipeDescription);
                        wout.SetMeta(meta);
                        list.Add(wout);
                        i++; j++;
                        continue;
                    }


                    bool PickLeftItem = true;

                    if (DoLeftSideFirst)
                    {
                        PickLeftItem = (left != null);
                    }
                    else
                    {
                        PickLeftItem = isLeftCloser(item, left, right, multiplyLbyThisToGetR);
                    }
                    if (PickLeftItem)
                    {
                        if (JustMatchOne)
                        {
                            IPipeDescription prefectmatch = FindThePerfectMatch(rightItems, left, ref j, multiplyLbyThisToGetR);
                            var outp2 = new T();
                            outp2.SetLeft(left as IPipeDescription);
                            i++;
                            var meta = new MetaData();
                            if (prefectmatch != null)
                            {
                                outp2.SetRight(prefectmatch as IPipeDescription);
                                meta.MetalLossIdentifier = "Matched";
                                outp2.SetMeta(meta);
                                j++;

                                //rightItems.Remove(prefectmatch);
                            }
                            else
                            {
                                meta.MetalLossIdentifier = "Left Only";
                                outp2.SetMeta(meta);
                            }
                            list.Add(outp2);
                            continue;
                        }
                        else
                        {
                            List<IPipeDescription> matchingList = howManyAreInOther(rightItems, left, j, multiplyLbyThisToGetR);
                            if (matchingList.Any())
                            {
                                bool first = true;
                                foreach (var rightone in matchingList)
                                {
                                    var outp2 = new T();
                                    var meta = new MetaData();
                                    meta.MetalLossIdentifier = matchingList.Count() == 1 ? "Pair from Left" : "1 to Many";
                                    outp2.SetRight(rightItems[j] as IPipeDescription);
                                    outp2.SetMeta(meta);

                                    j++;
                                    if (first)
                                    {
                                        outp2.SetLeft(left as IPipeDescription);
                                        first = CopyManyToOnes;
                                    }
                                    list.Add(outp2);
                                }
                                i++;
                                continue;

                            }
                            else
                            {
                                var outp2 = new T();
                                outp2.SetLeft(left as IPipeDescription);
                                var meta = new MetaData();
                                meta.MetalLossIdentifier = "left only";
                                outp2.SetMeta(meta);
                                list.Add(outp2);
                                i++;
                                continue;
                            }
                        }
                    }
                    else //right is closer
                    {

                        if (JustMatchOne)
                        {
                            IPipeDescription prefectmatch = FindThePerfectMatch(LeftItems, right, ref i, (1 / multiplyLbyThisToGetR));
                            var outp2 = new T();
                            outp2.SetRight(right as IPipeDescription);
                            var meta = new MetaData();
                            j++;
                            if (prefectmatch != null)
                            {
                                meta.MetalLossIdentifier = "Matched";
                                outp2.SetLeft(prefectmatch as IPipeDescription);
                                outp2.SetMeta(meta);
                                i++;
                                //LeftItems.Remove(prefectmatch);
                            }
                            else
                            {
                                meta.MetalLossIdentifier = "Right Only";
                                outp2.SetMeta(meta);
                            }
                            list.Add(outp2);
                            continue;
                        }
                        else
                        {
                            var secondMatchingList = howManyAreInOther(LeftItems, right, i, (1 / multiplyLbyThisToGetR));
                            if (secondMatchingList.Any())
                            {
                                bool first = true;
                                foreach (var leftone in secondMatchingList)
                                {
                                    var outp2 = new T();
                                    var meta = new MetaData();
                                    meta.MetalLossIdentifier = secondMatchingList.Count() == 1 ? "Pair from Right" : "Many to 1";
                                    outp2.SetLeft(LeftItems[i] as IPipeDescription);
                                    outp2.SetMeta(meta);
                                    i++;
                                    if (first)
                                    {
                                        outp2.SetRight(right as IPipeDescription);
                                        first = CopyManyToOnes;
                                    }

                                    list.Add(outp2);
                                }
                                j++;
                                continue;
                            }
                            else
                            {
                                var outp2 = new T();
                                outp2.SetRight(right as IPipeDescription);
                                var meta = new MetaData();
                                meta.MetalLossIdentifier = "right only";
                                outp2.SetMeta(meta);
                                list.Add(outp2);
                                j++;
                                continue;
                            }
                        }
                    }
                }
            }
            return list;

        }

        private double tolerance = .5;
        private IPipeDescription FindThePerfectMatch(List<IPipeDescription> listOfSegments, IPipeDescription singleSegment, ref int index, double ratio)
        {
            if (listOfSegments == null || listOfSegments.Count == 0) return null;
            double bestAbsDiff = 89127489;
            var trueStart = singleSegment.DistanceFromWeld * ratio;
            IPipeDescription returningTicket = null;

            for (int i1 = index; i1 < listOfSegments.Count; i1++)
            {
                IPipeDescription seg = listOfSegments[i1];


                if (singleSegment?.FeatureType != seg?.FeatureType)
                    continue;
                var value = Math.Abs(seg.DistanceFromWeld - trueStart);

                if (value < tolerance)
                {
                    if (value < bestAbsDiff)
                    {
                        returningTicket = seg;
                        bestAbsDiff = value;
                        index = i1;
                    }
                }
            }
            return returningTicket;
        }

        private List<IPipeDescription> howManyAreInOther(List<IPipeDescription> listOfSegments, IPipeDescription singleSegment, int i, double ratio)
        {
            var list = new List<IPipeDescription>();
            if (singleSegment?.FeatureType == Weld || singleSegment?.FeatureType == "Other") return list;
            for (int i1 = i; i1 < listOfSegments.Count; i1++)
            {
                IPipeDescription seg = listOfSegments[i1];

                var trueStart = singleSegment.DistanceFromWeld * ratio;
                var trueLength = singleSegment.MLLength * ratio;

                if (seg.DistanceFromWeld >= trueStart && seg.DistanceFromWeld < (trueStart + trueLength))
                    list.Add(seg);
            }
            return list;
        }

        private bool isLeftCloser(CombinedPipe item, IPipeDescription left, IPipeDescription right, double ratio)
        {
            if (left == null) return false;
            if (right == null) return true;

            var realleft = left.DistanceFromWeld * ratio;

            if (realleft <= right.DistanceFromWeld)
                return true;
            return false;
        }

        public List<Pipe> TurnFeaturesIntoPipes(List<IPipeDescription> pipefeatures, bool findUpStreamDistance = false)
        {
            List<Pipe> thisPipe = new List<Pipe>() { new Pipe() };
            foreach (var newitems in pipefeatures)
            {
                newitems.FeatureType = StringToType(newitems.FeatureDescription);

                if (newitems.FeatureType == "Weld")
                {
                    var pipe = new Pipe(false);
                    pipe.Odometer = newitems.Odometer;
                    pipe.Pipelength = newitems.PipeLengthFT ?? 0;
                    thisPipe.Add(pipe);
                }
                if (findUpStreamDistance)
                    newitems.DistanceFromWeld = newitems.Odometer - thisPipe[thisPipe.Count - 1].Odometer;
                thisPipe[thisPipe.Count - 1].AddPipeFeature(newitems);
            }
            return thisPipe;
        }

        public const string Weld = "Weld";
        public const string MetalLoss = "Metal Loss";
        public string StringToType(string input)
        {
            //NOT BEING USED!! ! DONT WORRY ABOUT THIS


            //ML Int Cluster At Weld happens sometimes 
            //it should be a metal loss and not a weld so moving weld to bottom
            if (input.ToLower().Contains("welded sleeve"))
                return "Other";
            if (input.ToLower().Contains("longitudinal weld anomaly"))
                return "Other";
            if (input.ToLower().Contains("weld") && ! input.ToLower().Contains("repair"))
                return Weld;
            if (input.ToLower().Contains("ml"))
                return MetalLoss;
            if (input.ToLower().Contains("metal"))
                return MetalLoss;
            if (input.ToLower().Contains("cluster"))
                return MetalLoss;
            if (input.ToLower().Contains("mill anomaly"))
                return MetalLoss;
            if (input.ToLower().Contains("group"))
                return MetalLoss;
            if (input.ToLower().Contains("corrosion"))
                return MetalLoss;
            return "Other";

        }

        public void SquashList()
        {
            var newPIpes = new List<CombinedPipe>();

            var ListOfJustLefts = new List<Pipe>();
            var ListOfJustRights = new List<Pipe>();


            for (int i = 0; i < Pipes.Count; i++)
            {
                CombinedPipe item = Pipes[i];
                if (item.Left != null && item.Right != null)
                {
                    //once you find a perfect match, zip up the previously unperfect matches to each other
                    tryToMatchLeftandRIght(ref ListOfJustLefts, ref ListOfJustRights, ref newPIpes);

                    var m = new MetaData();
                    m.Match = "Perfect Match";
                    m.OdometerDifference = item.Left.Odometer - item.Right.Odometer;
                    m.SizeDifference = 0;
                    item.CombinedPipeMetaData = m;
                    newPIpes.Add(item);
                }
                else if (item.Right != null)
                {
                    ListOfJustRights.Add(item.Right);


                }
                else if (item.Left != null)
                {
                    ListOfJustLefts.Add(item.Left);

                }
            }

            tryToMatchLeftandRIght(ref ListOfJustLefts, ref ListOfJustRights, ref newPIpes);
            Pipes = newPIpes;
        }

        public void JustSquashPipes(List<Pipe> ListOfJustLefts, List<Pipe> ListOfJustRights)
        {
            var newPIpes = new List<CombinedPipe>();

            tryToMatchLeftandRIght(ref ListOfJustLefts, ref ListOfJustRights, ref newPIpes);
            Pipes = newPIpes;
        }

        private void tryToMatchLeftandRIght(ref List<Pipe> listOfJustLefts, ref List<Pipe> listOfJustRights, ref List<CombinedPipe> newPIpes)
        {
            var max = listOfJustLefts.Count > listOfJustRights.Count ? listOfJustLefts.Count : listOfJustRights.Count;

            for (int i = 0; i < max; i++)
            {
                var item = new CombinedPipe();
                var l = listOfJustLefts.ElementAtOrDefault(i);
                var r = listOfJustRights.ElementAtOrDefault(i);
                item.Left = l;
                item.Right = r;
                if (l != null && r != null)
                {
                    var m = new MetaData();
                    m.Match = "Guess Match";

                    m.OdometerDifference = item.Left.Odometer - item.Right.Odometer;
                    m.SizeDifference = 0;
                    item.CombinedPipeMetaData = m;
                }
                else
                {
                    var m = new MetaData();
                    m.Match = "No Match";
                    item.CombinedPipeMetaData = m;
                }
                newPIpes.Add(item);
            }

            listOfJustLefts.Clear();
            listOfJustRights.Clear();
        }

        public List<CombinedPipe> Pipes { get; set; } = new List<CombinedPipe>();
        public bool isFirstMatch { get; set; } = true;
        public double FirstRight { get; set; } = 56.85;
        public double FirstLeft { get; set; } = 63.70;

        public PipeDetails()
        {
        }

        int HighestIndexedMatched = 0;
        private int IndexofLastMatchedPipe = 0;
        public double LastOdometerDifference = 7;
        public double PreviousLastOdometerDifference = 7;

        public void AddBoth(List<Pipe> leftPipes, List<Pipe> rightPipes)
        {
            int j = 0;
            int i = 0;

            Pipe leftPipe = leftPipes[i];
            Pipe rightPipe = rightPipes[j];



            if (leftPipe.Odometer == 0)
            {
                if (rightPipe.Odometer == 0)
                {

                    Pipes.Add(new CombinedPipe() { Left = leftPipe, Right = rightPipe, Matched = "P" });
                    i++; j++;
                }
                else
                {
                    Pipes.Add(new CombinedPipe() { Left = leftPipe });
                    i++;
                }
            }
            else if (rightPipe.Odometer == 0)
            {
                Pipes.Add(new CombinedPipe() { Right = rightPipe });
                j++;
            }

            while (i < leftPipes.Count || j < rightPipes.Count)
            {


                leftPipe = leftPipes.ElementAtOrDefault(i);
                rightPipe = rightPipes.ElementAtOrDefault(j);

                if (rightPipe == null)
                {
                    Pipes.Add(new CombinedPipe() { Left = leftPipe });
                    i++;
                    continue;
                }
                else if (leftPipe == null)
                {
                    Pipes.Add(new CombinedPipe() { Right = rightPipe });
                    j++;
                    continue;
                }



                if (AreTheyTheSamePipe(leftPipe, rightPipe))
                {
                    Pipes.Add(new CombinedPipe() { Left = leftPipe, Right = rightPipe });
                    PreviousLastOdometerDifference = LastOdometerDifference;
                    LastOdometerDifference = leftPipe.Odometer - rightPipe.Odometer;
                    IndexofLastMatchedPipe = Pipes.Count - 1;
                    i++; j++;
                    continue;
                }
                else if (DoesRightOneMatchAnyWeHaventPairedYet(leftPipe, rightPipe))
                {
                    j++;
                    continue;
                }
                else if (DoesLefttOneMatchAnyWeHaventPairedYet(leftPipe, rightPipe))
                {
                    i++;
                    continue;
                }
                else
                {
                    //Put whatever one is lowest odometer


                    PreviousLastOdometerDifference = LastOdometerDifference;
                    var LeftO = leftPipe.Odometer - LastOdometerDifference;
                    var RightO = rightPipe.Odometer;

                    if (LeftO < RightO)
                    {
                        Pipes.Add(new CombinedPipe() { Left = leftPipe });
                        i++;
                        continue;
                    }
                    else
                    {
                        Pipes.Add(new CombinedPipe() { Right = rightPipe });
                        j++;
                        continue;
                    }
                }
            }
        }

        private bool DoesLefttOneMatchAnyWeHaventPairedYet(Pipe leftPipe, Pipe rightPipe)
        {
            for (int i = IndexofLastMatchedPipe; i < Pipes.Count; i++)
            {

                CombinedPipe item = Pipes[i];
                if (item.Left != null) continue;

                if (AreTheyTheSamePipe(leftPipe, item.Right))
                {
                    item.Left = leftPipe;
                    PreviousLastOdometerDifference = LastOdometerDifference;
                    LastOdometerDifference = leftPipe.Odometer - item.Right.Odometer;
                    IndexofLastMatchedPipe = i;
                    return true;
                }
            }
            return false;
        }

        private bool AreTheyTheSamePipe(Pipe left, Pipe right)
        {
            if (isFirstMatch)
            {
                if ((Math.Abs(FirstLeft - left.Odometer) < 1) && (Math.Abs(FirstRight - right.Odometer) < 1))
                {
                    isFirstMatch = false;
                    return true;
                }

            }
            else if (Math.Abs(left.Pipelength - right.Pipelength) < 1)
            {
                if (Math.Abs(right.Odometer - (left.Odometer - LastOdometerDifference)) < 20)
                    return true;
                //if (Math.Abs(newitem.Odometer - old.Odometer) < 20)
                //    return true;
            }
            return false;
        }

        private bool DoesRightOneMatchAnyWeHaventPairedYet(Pipe old, Pipe newitem)
        {

            for (int i = IndexofLastMatchedPipe; i < Pipes.Count; i++)
            {

                CombinedPipe item = Pipes[i];
                if (item.Right != null) continue;

                if (AreTheyTheSamePipe(item.Left, newitem))
                {
                    item.Right = newitem;
                    LastOdometerDifference = item.Left.Odometer - newitem.Odometer;
                    IndexofLastMatchedPipe = i;
                    return true;
                }
            }
            return false;

        }


    }

    internal interface IOutput
    {
        void SetLeft(IPipeDescription newILIItem);
        void SetRight(IPipeDescription oLDILIItem);

        void SetMeta(IMetaData metaData);
    }

    public class CombinedPipe
    {
        public Pipe Left { get; set; }
        public Pipe Right { get; set; }
        public string Matched { get; internal set; } = "U";

        public MetaData CombinedPipeMetaData { get; set; }
        public double OdometerDifference { get; internal set; }
        public double PipeLengthDifference { get; internal set; }
    }



    public class Pipe
    {
        public List<IPipeDescription> PipesItems { get; set; } = new List<IPipeDescription>();

        public double Odometer { get; set; }

        public double Pipelength { get; set; }

        public bool PipelengthiSum { get; set; }


        internal void AddPipeFeature(IPipeDescription old)
        {

            PipesItems.Add(old);
            if (PipelengthiSum)
                Pipelength = PipesItems.Sum(x => x.Odometer);
        }

        public Pipe(bool PipelengthIsSumOfFeatures = false)
        {
            PipelengthiSum = PipelengthIsSumOfFeatures;
        }
    }

    public interface IPipeDescription
    {
        string FeatureDescription { get; }
        double Odometer { get; }
        double? PipeLengthFT { get; }
        string FeatureType { get; set; }
        double DistanceFromWeld { get; set; }
        double MLLength { get; }
    }
}

