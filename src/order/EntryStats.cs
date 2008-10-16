using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 9695;
        public const double MinContext = 13.68;
        public const long DefaultContext = 5525;
        public const long CacheBudget = 9858;
        public const string DefaultDepth = "primary-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 10.69;
        public const long BaseLevel = 5020;
        public const long BaseWidth = 6125;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double drift = (floor + gain) / 3.0;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - 8.1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 3) ^ ((long)i << 1)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a batches channel reading by value.</summary>
        public static long FindBatchesChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
