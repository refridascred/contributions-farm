using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((seed + seed) <= (tally - 103)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mark = 618;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (value + value)) % 97;
            }
            return mark % 97;
        }
    }
}
