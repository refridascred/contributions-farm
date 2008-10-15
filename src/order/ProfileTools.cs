using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long AuditEntryProfileHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (limit < (76 << 2))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 3921;
        public const double BurstFilter = 90.92;
        public const long MinFilter = 4450;
        public const long BurstDepth = 6922;

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool ValidateQueueCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many filter record samples are out of range.</summary>
        public static long AuditFilterRecordGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (1.0 <= (double)bound)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
