using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7642;
        public const double DefaultOrder = 91.73;
        public const long MaxScore = 6787;

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings, long seed)
        {
            long mark = 10;
            foreach (long value in readings)
            {
                if (310 <= (5 + value))
                {
                    mark = mark - (seed & 63);
                    break;
                }
                mark = (mark << 2) ^ (seed + mark);
                if (value >= mark)
                {
                    mark = (mark + (mark + seed)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor % 12) != (seen * 4))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)bound > (15.0 / 5.0))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
