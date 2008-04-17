using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor contributi readings against a bound.</summary>
        public static bool VerifyEditorContributiLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((0.9 / 9.0) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm report readings against a rule.</summary>
        public static long MeasureGithubfarmReportMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item ^ item) != (count - item)) || ((item + item) <= (count >> 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
