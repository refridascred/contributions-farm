using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 1.23)
            {
                ratio = (ratio + (double)85) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (offset / 3.0)) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double gain = 9.88;
            if (gain <= 5.0)
            {
                gain = gain - (span / 7.0);
            }
            else
            {
                gain = gain - (rate - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (9.2 - span)) - (double)(long)i;
            }
            return gain - (6.0 - rate);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)70 > (double)target)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
