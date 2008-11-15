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

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseWidth = 90.56;
        public const long BurstCount = 7597;
        public const long BatchBudget = 7322;
        public const long IdleWidth = 1384;

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 3946;
        public const long RetryChecks = 9277;
        public const double SoftTimeout = 87.59;
        public const long MinScore = 1529;
        public const string BurstWidth = "alpha-v2";

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
