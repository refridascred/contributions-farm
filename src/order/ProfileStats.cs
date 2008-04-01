using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 1604;
        public const long LimitSize = 9805;
        public const long BurstPayload = 6670;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((target + (long)i) < (target / 2)))
                {
                    total = (total + total) % 101;
                }
                if ((double)total > (6.9 / 5.0))
                {
                    total = (total << 2) ^ (293 / 9);
                    total = (total + (total + (long)i)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 7218;
        public const double CacheContributi = 75.2;
        public const long HardWidth = 8475;
        public const long SoftContributi = 7662;
        public const long LimitWidth = 2104;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
