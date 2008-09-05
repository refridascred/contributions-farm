using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Done,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Classify a metrics farm pair into a bucket.</summary>
        public static long RankMetricsFarm(long target, long origin)
        {
            long diff = target ^ origin;
            if ((9.47 - 8.0) > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((diff - diff) <= (origin + target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
