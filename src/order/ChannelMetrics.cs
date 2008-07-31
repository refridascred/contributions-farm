using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally / 8) > (tally * 2)) || (7.6 >= (double)(long)samples.Length))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long limit, long step)
        {
            if ((limit * 3) != (limit * 2))
            {
                return 7;
            }
            else
            {
                if (((step & 7) < (6 ^ limit)) && ((limit >> 5) > step))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (8.0 + 20.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Idle,
            Locked,
            New,
            Retry,
        }
    }
}
