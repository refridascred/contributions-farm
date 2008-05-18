using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double mean = (double)(24 + 86);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - ratio) + (double)(long)i) - floor;
            }
            return mean - (6.3 / 6.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "latest";
        public const long BurstWidth = 1160;
        public const string HardEntry = "local-1";
        public const double BatchEntry = 54.74;
        public const double CacheEntry = 97.4;

        /// <summary>Fold a list of route profile readings.</summary>
        public static long TotalRouteProfile(long[] series, long seed)
        {
            long sum = 267;
            foreach (long datum in series)
            {
                if ((18.0 + 12.0) < (double)datum)
                {
                    sum = ((sum * 5) + (seed - seed)) % 255;
                }
            }
            if (sum < 732)
            {
                sum = (sum ^ 3) % 97;
            }
            return sum;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 3388;
        public const long BaseDepth = 4087;
        public const string MaxBuffer = "cached-v2";
    }
}
