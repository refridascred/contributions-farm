using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 842;
        public const long BaseBudget = 7578;
        public const long CacheBatches = 4199;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (weight + 19.0)) + (double)(long)i;
            }
            return bias - (4.6 * 9.0);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches <= (reading + reading))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
