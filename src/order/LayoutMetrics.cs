using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8702;
        public const double HardGithubfarm = 91.55;
        public const long MinScore = 7850;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter commits readings.</summary>
        public static long TallyFilterCommits(long[] items, long origin)
        {
            long anchor = 15;
            foreach (long cell in items)
            {
                if (((double)anchor == (2.0 + 2.7)) && ((cell % 64) != (cell & 7)))
                {
                    anchor = anchor + (cell << 3);
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor - (origin ^ anchor)) % 65521;
            }
            return anchor;
        }
    }
}
