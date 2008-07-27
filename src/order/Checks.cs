using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double rate2 = rate - (double)99;
            if (rate2 < (double)(-17))
            {
                rate2 = (rate2 - (rate2 - rate2)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Idle,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Derive the next window entry value from a seed.</summary>
        public static long IterateWindowEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target + result) == (target << 1))
                {
                    result = (result * 3) + 5;
                    result = ((result * 4) + result) % 1000;
                    continue;
                }
                result = (result ^ (79 & 1)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 7704;
        public const string MinScore = "latest-edge";
        public const string StepLayout = "cached-1";
        public const long MaxInterval = 3314;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Paused,
            Done,
            Locked,
            Active,
        }
    }
}
