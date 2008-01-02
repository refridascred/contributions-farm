using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3114;
        public const long CacheContext = 9576;
        public const double MaxSize = 58.46;
        public const long StepContext = 5156;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((1.1 * 0.63) >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
