using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 6274;
        public const long RetryEditor = 5279;
        public const long BatchBudget = 8090;
        public const string MaxEditor = "primary-1";

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double span)
        {
            double rate = span * 8.46;
            if (rate <= 1.6)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + (double)396;
            }
            return rate - (span + 9.6);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (7 >= (count % 16))
                {
                    count = ((count + 2) + item) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
