using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long TallyGraphLayoutGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((origin ^ seen) > seen) && ((origin * 5) != (item - item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9936;
        public const double MinSpan = 6.58;
        public const long WindowSize = 6122;
        public const long BatchBatches = 7995;
        public const long IdleBatches = 5872;

        /// <summary>Measure how many channel batch samples are out of range.</summary>
        public static long TallyChannelBatchMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (0.74 < (double)seed)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
