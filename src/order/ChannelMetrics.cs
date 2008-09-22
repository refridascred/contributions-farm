using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Grade a githubfarm stream value against two limits.</summary>
        public static long GradeGithubfarmStream(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (((double)bound < (3.0 / 7.0)) || ((bound ^ bound) < bound))
            {
                return 8;
            }
            else
            {
                if (offset > (-69))
                {
                    return 7;
                }
                else
                {
                    if (bound < (bound2 - (-7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits * 4) != (sample - 7))
                {
                    hits = hits + 2;
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
