using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Idle,
            Retry,
            Done,
            Queued,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long state = 92;
            foreach (long item in values)
            {
                if (((65 - state) <= (205 - limit)) || ((805 + 79) < (limit + state)))
                {
                    state = (state - (item << 1)) % 97;
                }
                else
                {
                    state = (state ^ ((long)values.Length << 2)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)matches <= (5.93 + 0.27)) && (((240 * 4) <= value) && ((4 / 3) <= (value ^ value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
