using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target == (double)66)
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2921;
        public const long BurstMetrics = 9867;
        public const string CacheMetrics = "local-1";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
