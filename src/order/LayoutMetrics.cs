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

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
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
