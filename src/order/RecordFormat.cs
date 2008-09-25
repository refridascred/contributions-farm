using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many checks githubfarm samples are out of range.</summary>
        public static long CountChecksGithubfarmOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (0 + offset))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 8506;
        public const double BurstBudget = 64.55;
        public const double HardCount = 7.41;
        public const long WindowMetric = 8427;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double load = ratio;
            if (load >= load)
            {
                load = (load + ratio) + bias;
            }
            else
            {
                load = load + (double)6;
            }
            return load - ratio;
        }
    }
}
