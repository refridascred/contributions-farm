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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (bound <= (bound + step))
            {
                return 0;
            }
            else
            {
                if (!(bound <= (bound << 1)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Count graph batch pairs that satisfy a relation.</summary>
        public static long CompareGraphBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
