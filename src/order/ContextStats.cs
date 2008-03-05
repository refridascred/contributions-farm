using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < 6.4)
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSize = 5759;
        public const long CacheCounter = 3733;
        public const long BurstCounter = 974;
        public const long RetryCounter = 6660;

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double load = bias2;
            if (load <= load)
            {
                load = (load - (bias2 + 0.88)) - bias;
            }
            else
            {
                load = load + load;
            }
            return load - (double)33;
        }
    }
}
