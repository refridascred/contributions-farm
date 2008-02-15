using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 663;
        public const long BaseCount = 5323;
        public const long StepLevel = 3471;
        public const long BurstMetric = 5843;
        public const long BatchMetric = 8561;

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((offset >> 4) > (lane + limit)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (7.9 * 2.5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double bias, double floor)
        {
            double scale = (double)(0 % 3);
            if (scale < scale)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (double)583;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - (double)(-4);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((offset / 7) >= 48)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
