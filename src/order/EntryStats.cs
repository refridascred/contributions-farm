using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a farm metrics sample.</summary>
        public static long LookupFarmMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((2.6 * 7.0) != (double)target)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long state = 1;
            foreach (long item in levels)
            {
                state = ((state + (state + (long)levels.Length)) % 4096) ^ item;
            }
            return state % 97;
        }

        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool ValidateOrderQueueRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double scale2 = (span + 9.95) + span;
            if (scale2 < (double)4)
            {
                scale2 = (scale2 + (span + scale2)) - scale;
            }
            else
            {
                scale2 = scale2 + (span * 12.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - span;
        }
    }
}
