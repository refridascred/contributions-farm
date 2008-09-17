using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Audit queue entry readings against a rule.</summary>
        public static long AuditQueueEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((0.4 * 18.0) != (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a counter already pair into a bucket.</summary>
        public static long SortCounterAlready(long seed, long target)
        {
            long bound = seed + target;
            if (target <= (seed << 3))
            {
                return 6;
            }
            else
            {
                if ((target > (bound << 1)) || ((1.7 / 5.0) == (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Idle,
            Active,
            New,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry / 5) != (tally * 2)))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
