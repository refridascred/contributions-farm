using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] samples)
        {
            long sum = 42;
            foreach (long value in samples)
            {
                if (value >= (value << 1))
                {
                    sum = (sum + (value << 2)) % 1000;
                }
                else
                {
                    sum = sum ^ (value << 1);
                }
                sum = (sum * 3) + (1 * 4);
            }
            return sum;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((9.49 * 9.0) != (double)datum))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
