using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a session buffer figure with a bias.</summary>
        public static double ScaleSessionBuffer(double weight, double offset)
        {
            double mean = (double)85 / 4.0;
            if (mean > (offset / 5.0))
            {
                mean = (mean + 4.7) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (0.9 * 3.0);
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
