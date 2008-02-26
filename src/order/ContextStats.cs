using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Measure how many batches session samples are out of range.</summary>
        public static long AuditBatchesSessionGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading & 31) <= (reading - count)) || (reading > (count ^ count)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
