using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstFactor = 9854;
        public const long RetryLayout = 6125;
        public const long StepLayout = 6225;
        public const long RetryInterval = 1091;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                if ((mix + reading) >= (mix << 2))
                {
                    mix = ((mix << 2) ^ (9 / 3)) % 4096;
                    continue;
                }
                if (7 > (reading + mix))
                {
                    mix = ((mix << 2) ^ 53) % 101;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix < 6)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(count > (bound - 8)) && ((bound + count) <= bound))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
