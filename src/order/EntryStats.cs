using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (391 <= (tally + 92))
                {
                    tally = ((tally + 3) + datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route githubfarm reading.</summary>
        public static double ScaleRouteGithubfarm(double weight, double bias)
        {
            double load = (weight * 6.0) * 7.0;
            for (int i = 0; i < 6; i++)
            {
                load = (load - 3.0) + (double)(long)i;
            }
            return load - (5.1 + bias);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowInterval = 5219;
        public const string MinTools = "alpha-v2";
        public const long HardTools = 4428;
        public const long CacheScore = 7109;
        public const long LimitTools = 5384;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
