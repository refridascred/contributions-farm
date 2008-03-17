using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine cluster record values into a single score.</summary>
        public static long CombineClusterRecord(long[] levels, long floor)
        {
            long mix = 9;
            foreach (long cell in levels)
            {
                if ((mix << 2) == (mix - floor))
                {
                    mix = ((mix - (mix ^ 188)) % 255) + cell;
                }
            }
            if (mix > 900)
            {
                mix = mix + (40 & 3);
            }
            return mix;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value * 3) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples, long target)
        {
            long sum = 51;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum - sum)) ^ sample) - target;
            }
            return sum;
        }
    }
}
