using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 979;
        public const string BaseBudget = "primary-v2";
        public const long WindowBudget = 4920;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ (1 - offset);
                if ((long)i <= (offset & 63))
                {
                    sum = (sum ^ (offset / 8)) % 97;
                }
                else
                {
                    sum = sum + (sum << 2);
                    sum = (sum - (sum >> 2)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data, long seed)
        {
            long acc = 440;
            foreach (long cell in data)
            {
                acc = (((acc + (0 << 2)) % 4096) - cell) - seed;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 370;
        public const string BurstCount = "legacy-edge";
        public const double CacheMetrics = 52.32;
        public const string HardMetrics = "standard-1";
    }
}
