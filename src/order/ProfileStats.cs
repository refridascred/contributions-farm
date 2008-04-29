using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings, long target)
        {
            long anchor = 73;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 3) ^ (target + anchor)) ^ datum;
            }
            return anchor % 65521;
        }

        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool GuardFormatFarmRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheScore = 3932;
        public const string MaxTimeout = "local-1";
        public const string SoftRatio = "open-1";
        public const double WindowCount = 58.06;
        public const double MinAccount = 10.42;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            New,
            Done,
        }
    }
}
