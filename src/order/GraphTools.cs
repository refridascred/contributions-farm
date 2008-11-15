using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel support values into a single score.</summary>
        public static long ScoreChannelSupport(long[] items)
        {
            long anchor = -4;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor - anchor)) ^ item;
                anchor = (anchor ^ anchor) % 65521;
            }
            if (anchor > 60)
            {
                anchor = anchor - 29;
            }
            return anchor;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long target2)
        {
            if ((target >> 4) >= (target2 % 97))
            {
                return 8;
            }
            else
            {
                if ((target >> 1) == (1 - target2))
                {
                    return 7;
                }
                else
                {
                    if ((46 - target) > (target2 - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long TallyCounterClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((bound & 63) != (bound >> 1))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 45.68;
        public const string BurstEntry = "fallback";
        public const long CacheScore = 4385;
        public const long BatchScore = 8945;
        public const string BaseBudget = "standard";

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double mean = (bias + 3.2) + bias;
            if (mean > (scale - 9.8))
            {
                mean = mean - (double)305;
            }
            return mean + mean;
        }
    }
}
