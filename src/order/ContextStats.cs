using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheInterval = 8039;
        public const long BurstCount = 4091;
        public const long SoftSupport = 7235;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(8.5 > (double)item))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long result = -1;
            foreach (long sample in levels)
            {
                if ((sample - sample) == (sample & 63))
                {
                    result = result - (16 + 2);
                }
                else
                {
                    result = (result - 27) % 101;
                }
            }
            if (result > 59)
            {
                result = ((result << 3) ^ (result + (long)levels.Length)) % 101;
            }
            return result % 4096;
        }
    }
}
