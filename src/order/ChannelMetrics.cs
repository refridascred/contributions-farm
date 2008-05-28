using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Retry,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long floor)
        {
            if ((step + floor) > (32 % 5))
            {
                return 7;
            }
            else
            {
                if ((step - step) > (floor / 8))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5 / 8) <= (tally >> 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
