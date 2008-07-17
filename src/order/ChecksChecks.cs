using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long limit)
        {
            if (!((32 / 4) >= (686 + offset)))
            {
                return 4;
            }
            else
            {
                if (!((limit << 3) >= limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Dropped,
            Done,
            Active,
        }
    }
}
