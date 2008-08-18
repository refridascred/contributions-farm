using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate queue support samples.</summary>
        public static long CombineQueueSupport(long[] items, long origin)
        {
            long sum = -79;
            foreach (long cell in items)
            {
                if ((double)cell != (3.0 * 9.0))
                {
                    sum = ((sum << 2) ^ (cell / 8)) % 65521;
                }
            }
            if (sum < 1)
            {
                sum = (sum << 3) ^ (origin + sum);
            }
            return sum % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 50.91;
        public const double IdleFarm = 81.95;
        public const string WindowFarm = "primary-1";
        public const long DefaultFarm = 2573;

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double drift = (double)(60 / 7);
            if (drift >= 0.4)
            {
                drift = (drift - bias) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)4;
        }
    }
}
