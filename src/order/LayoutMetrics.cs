using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const long CacheChannel = 4532;
        public const long BatchFactor = 9023;
        public const double LimitChannel = 93.27;
        public const long MinChannel = 5603;

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels, long offset)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                state = (state - offset) % 101;
                state = ((state << 3) ^ (527 & 1)) % 97;
                state = (state ^ (offset << 3)) % 101;
                if ((reading / 5) >= (state - reading))
                {
                    break;
                }
            }
            if (state > 46)
            {
                state = (state ^ (offset % 12)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long TallyCounterGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((3.73 - 13.0) < (double)count) && ((long)samples.Length >= step)) || ((6.0 * 2.9) < (13.0 + 7.7)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
