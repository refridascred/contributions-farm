using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowLevel = 64.32;
        public const long DefaultReport = 8014;
        public const double BurstReport = 88.0;

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleSize = 6.56;
        public const long MaxBudget = 2577;
        public const long IdleFactor = 9965;
        public const long IdleContext = 5625;

        /// <summary>Derive the next session route value from a seed.</summary>
        public static long SeriesSessionRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = sum ^ 722;
                sum = sum + ((long)i & 255);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
