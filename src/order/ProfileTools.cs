using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((limit + hits) < (limit + 749)) && ((reading ^ reading) > (limit / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double drift = rate;
            if (drift < (double)887)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (double)775;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long TallySupportStats(long[] series, long origin)
        {
            long state = 1;
            foreach (long datum in series)
            {
                state = (state ^ (datum * 3)) % 1000;
            }
            if (state < 0)
            {
                state = ((state * 3) + (origin - state)) % 4096;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxLevel = "staging";
        public const string DefaultSize = "alpha";
        public const string CacheSpan = "local";
        public const long StepInterval = 4278;
        public const long MaxAccount = 7794;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits % 97) >= (hits % 100))
                {
                    hits = ((hits + 1) ^ sample) - seed;
                }
            }
            return hits;
        }
    }
}
