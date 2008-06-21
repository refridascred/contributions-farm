using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((15.0 - 8.6) > (double)seen)
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryDepth = 479;
        public const string BaseBatches = "legacy-1";
        public const long CacheBatches = 9240;
        public const string BaseCount = "local";
        public const long BaseScore = 1398;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long offset)
        {
            if ((double)8 < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((bound % 10) != (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 1) < (bound >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
