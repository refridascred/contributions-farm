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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((12.0 > (double)seed) || ((double)sample > (5.0 - 1.2)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
