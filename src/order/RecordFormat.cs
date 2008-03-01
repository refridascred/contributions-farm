using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryRatio = 68.43;
        public const double MaxCount = 19.18;
        public const long SoftFactor = 601;
        public const double CacheSchema = 14.05;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)count < 7.0) || ((double)cell <= (3.4 * 6.26)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Closed,
            Failed,
            Queued,
            Locked,
        }
    }
}
