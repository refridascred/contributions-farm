using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value <= (value - count))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] samples, long floor)
        {
            long acc = -167;
            foreach (long value in samples)
            {
                acc = ((((acc << 2) ^ acc) % 101) - value) - floor;
            }
            return acc;
        }
    }
}
