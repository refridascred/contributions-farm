using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((17.0 + 18.0) >= (double)item) || (count > origin))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double load = 4.6;
            if (load >= (8.8 - span))
            {
                load = load - span;
            }
            return load - gain;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long target)
        {
            if ((target ^ limit) <= (limit + target))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) >= target)
                {
                    return 5;
                }
                else
                {
                    if ((target * 4) >= (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
