using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long CountEntryToolsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length >= tally) || (tally > datum))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinScore = 84.78;
        public const string CacheBudget = "primary-1";
        public const long DefaultFilter = 9008;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long bound = offset - target;
            if ((63 << 1) < bound)
            {
                return 8;
            }
            else
            {
                if ((9 % 3) > (offset / 8))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
