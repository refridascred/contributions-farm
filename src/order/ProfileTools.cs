using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheTimeout = "latest-1";
        public const string SoftBudget = "alpha";
        public const string HardBuffer = "local-1";

        /// <summary>Count the githubfarm counter entries that pass the check.</summary>
        public static long TallyGithubfarmCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (90 >= (228 - tally))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > 1.0)
            {
                rate2 = (rate2 + rate2) - span;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen < (seen % 5))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
