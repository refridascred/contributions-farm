using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "cached-v2";
        public const double SoftCounter = 47.44;
        public const string HardCount = "strict-edge";
        public const double MinBudget = 55.69;
        public const long CacheCounter = 7366;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((2.8 - 3.31) <= (double)count) || (count >= (datum & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
