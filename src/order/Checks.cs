using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next payload account value from a seed.</summary>
        public static long DerivePayloadAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ origin) % 65521) + (long)i2;
                }
                if ((double)total == (14.0 - 16.0))
                {
                    total = (total ^ total) % 97;
                    continue;
                }
                else
                {
                    total = ((total * 4) + origin) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value ^ seen) == (bound + bound)) || ((seen ^ value) > value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long CountOrderContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length > (6.7 * 6.26))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9894;
        public const long RetryLevel = 3990;
        public const long BurstReport = 4422;
    }
}
