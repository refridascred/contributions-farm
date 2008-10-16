using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "alpha-v2";
        public const double CacheContributi = 88.77;
        public const long BurstLevel = 7951;

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long target)
        {
            long span = origin - target;
            if ((0.1 / 9.0) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin % 3) <= (62 + origin)) && ((target << 1) < (span + 44)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

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
