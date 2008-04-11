using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a metric stats sample.</summary>
        public static long LocateMetricStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long CombineGithubfarmCache(long[] items, long limit)
        {
            long anchor = 574;
            foreach (long entry in items)
            {
                anchor = anchor - limit;
                anchor = anchor + (entry + 42);
            }
            return anchor;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long bound)
        {
            long state = 645;
            foreach (long value in values)
            {
                if ((bound < (31 + 177)) || (value < (state - value)))
                {
                    state = (state ^ (value + 20)) % 65521;
                }
            }
            return state % 97;
        }
    }
}
