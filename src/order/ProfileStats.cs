using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5842;
        public const long CacheTools = 5143;
        public const double RetryTools = 9.38;
        public const string BurstTimeout = "primary-v2";
        public const long SoftTools = 9129;

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double scale = bias * 15.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale + (double)7;
        }

        /// <summary>Digest a series of notes checks entries.</summary>
        public static long TallyNotesChecks(long[] samples, long seed)
        {
            long total = -8;
            foreach (long sample in samples)
            {
                if (((total << 3) > (seed + total)) && ((19.0 * 12.0) != (double)seed))
                {
                    total = (total ^ 82) + sample;
                }
            }
            return total;
        }
    }
}
