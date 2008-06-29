using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 50.15;
        public const long CacheOrder = 1840;
        public const long MaxOrder = 721;
        public const string MinOrder = "legacy-edge";
        public const string BurstDepth = "primary-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 82.54;
        public const long BatchStats = 3100;
        public const string HardStats = "cached-edge";
        public const long BurstStats = 3257;
        public const long CacheStats = 7999;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((2.69 / 8.0) >= (double)cell) || ((hits / 6) < hits)) && ((hits >= (cell * 4)) && ((double)cell <= (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 < rate2)
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 + (rate * 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (0.33 + bias);
        }
    }
}
