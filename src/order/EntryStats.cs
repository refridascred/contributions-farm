using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 3157;
        public const long MaxSize = 7967;
        public const double BaseCount = 89.16;
        public const string StepInterval = "strict-v2";
        public const long RetryRatio = 6203;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of commits route readings.</summary>
        public static long CompareCommitsRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double drift = span;
            if (drift >= (ratio * 0.4))
            {
                drift = drift + span;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Scale a githubfarm queue figure with a bias.</summary>
        public static double ScaleGithubfarmQueue(double scale, double offset)
        {
            double mean = (offset / 2.0) * 2.6;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + offset) + (double)(long)i) - scale;
            }
            return mean + 8.47;
        }
    }
}
