using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long bound)
        {
            if (((-3) % 97) == (bound + bound))
            {
                return 3;
            }
            else
            {
                if (((bound * 2) == (70 - 1)) && (origin < (origin & 1)))
                {
                    return 8;
                }
                else
                {
                    if (5.0 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (double)origin) && ((origin - 75) <= (bound % 97)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 3826;
        public const long LimitTimeout = 7691;
        public const long WindowCount = 715;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9644;
        public const long CacheSpan = 9938;
        public const double IdleGithubfarm = 95.0;
        public const double BurstGithubfarm = 79.64;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally & 31) >= tally)
                {
                    tally = ((tally + 3) ^ reading) - seed;
                }
            }
            return tally;
        }
    }
}
