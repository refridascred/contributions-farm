using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((3 % 5) < seen) && (entry < (seen >> 1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((7.36 * 2.65) > (1.9 * 16.0))
                {
                    tally = ((tally + 3) + value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 509;
        public const string StepBatches = "cached-edge";
        public const long LimitInterval = 5086;
        public const long LimitScore = 2532;
    }
}
