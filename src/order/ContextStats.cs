using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 3841;
        public const long LimitSchema = 3842;
        public const string CacheSchema = "staging-v2";
        public const long BaseScore = 8102;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - tally) <= (111 + tally))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + step) < (mark >> 5))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many token contributi samples are out of range.</summary>
        public static long TallyTokenContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length > (double)(-96))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
