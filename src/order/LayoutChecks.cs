using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 92.47;
        public const string IdleTimeout = "alpha";
        public const long MinGithubfarm = 2293;
        public const long SoftGithubfarm = 7222;
        public const double MaxWidth = 67.36;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next cache layout value from a seed.</summary>
        public static long StepCacheLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 2) ^ (floor & 15)) % 65521) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchTimeout = "fallback-edge";
        public const long DefaultOrder = 8179;
        public const long LimitOrder = 5391;
        public const long HardOrder = 4567;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
