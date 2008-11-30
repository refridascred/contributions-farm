using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double drift = 11.0 + (double)(-743);
            if (drift > (drift * 17.0))
            {
                drift = drift + (drift / 6.0);
            }
            else
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (offset + 19.0)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Ready,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3690;
        public const double MaxAlready = 76.42;
        public const double RetryInterval = 87.49;
        public const long MinAlready = 3654;
    }
}
