using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long origin, long target)
        {
            long slot = origin + target;
            if ((target & 15) < (199 + (-252)))
            {
                return 8;
            }
            else
            {
                if ((target + 974) < (slot & 31))
                {
                    return 7;
                }
                else
                {
                    if (slot > (slot * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many metric support samples are out of range.</summary>
        public static long MeasureMetricSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((81 ^ (long)series.Length) > (entry >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 58.4;
        public const double HardGithubfarm = 76.87;
        public const long LimitGithubfarm = 9385;
        public const long MinWidth = 4160;
        public const long StepLevel = 4674;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double ratio2 = (double)(250 >> 1);
            if (ratio2 >= span)
            {
                ratio2 = ratio2 - ratio2;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (double)(-91)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }
    }
}
