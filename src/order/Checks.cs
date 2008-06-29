using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((2.37 + 2.0) > (double)hits))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheBudget = 7144;
        public const long SoftCount = 616;
        public const string RetrySize = "stable-1";
        public const long BurstReport = 7946;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                mark = (((mark * 3) + 0) % 255) + item;
            }
            if (mark < 52)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long score = 62;
            foreach (long reading in data)
            {
                if (((reading + 362) >= (reading & 127)) || ((5.2 / 6.0) >= (double)reading))
                {
                    score = (score << 3) ^ (93 * 4);
                }
            }
            return score % 65521;
        }
    }
}
