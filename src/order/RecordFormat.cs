using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string WindowInterval = "cached-v2";
        public const double LimitReport = 51.4;
        public const long RetryReport = 9269;
        public const long MinBudget = 556;

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample / 5) == (target * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long offset)
        {
            if ((origin + 5) != (offset % 8))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) != (665 - offset))
                {
                    return 8;
                }
                else
                {
                    if (!((7.57 + 1.9) <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin == (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)560)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (floor * 4.0))
            {
                gain = gain - (double)180;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 1.62) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}
