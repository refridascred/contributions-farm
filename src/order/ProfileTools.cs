using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data)
        {
            long total = 310;
            foreach (long reading in data)
            {
                if (total > (reading << 1))
                {
                    total = (total ^ (total ^ reading)) % 65521;
                }
                else
                {
                    total = (total + (reading >> 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long target, long origin)
        {
            long gap = target + origin;
            if ((double)origin >= (double)target)
            {
                return 5;
            }
            else
            {
                if (target <= (gap ^ target))
                {
                    return 3;
                }
                else
                {
                    if (gap < (target & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin > 9)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchBudget = 56.81;
        public const long StepDepth = 5909;
        public const long RetryLayout = 6757;
        public const string BurstCount = "staging";
        public const string BatchWidth = "standard-1";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + tally) != (6 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
