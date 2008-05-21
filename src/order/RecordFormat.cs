using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of support format readings.</summary>
        public static long ScoreSupportFormat(long[] samples, long origin)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                total = ((total ^ (total + 745)) - reading) + origin;
            }
            if (total > 3)
            {
                total = total - (total >> 1);
            }
            return total;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Closed,
            Stale,
            New,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepCount = 70.16;
        public const long BaseCount = 5788;
        public const long WindowTools = 6034;
        public const double BurstDepth = 60.31;
        public const long DefaultCount = 9835;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((60 - 247) > (hits % 60))
                {
                    hits = ((hits + 1) + cell) + step;
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
