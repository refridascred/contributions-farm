using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a context buffer reading by value.</summary>
        public static long LookupContextBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Retry,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long seed)
        {
            long span = floor - seed;
            if (((span - span) < (floor & 15)) || ((7.5 * 20.0) >= (double)span))
            {
                return 6;
            }
            else
            {
                if ((seed + floor) < (seed - floor))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Queued,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double mean = 4.9;
            if (mean >= mean)
            {
                mean = (mean - (floor * 19.0)) - ratio;
            }
            return mean - (double)92;
        }
    }
}
