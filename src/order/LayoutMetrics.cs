using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many farm cluster samples are out of range.</summary>
        public static long TallyFarmClusterGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((883 - item) < (step + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 6071;
        public const string IdleInterval = "primary-1";
        public const double LimitWidth = 86.12;
        public const double MaxGithubfarm = 69.97;

        /// <summary>Check that every schema contributi entry stays within the limit.</summary>
        public static bool GuardSchemaContributiLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
