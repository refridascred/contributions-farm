using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Measure how many entry window samples are out of range.</summary>
        public static long AuditEntryWindowGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum - tally) <= (tally << 1)) || (((long)levels.Length % 10) == (datum - tally)))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long BucketStatsRecord(long origin, long origin2)
        {
            if ((origin % 16) <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((origin2 & 15) != (origin2 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin2 != (8.0 - 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((origin2 - origin2) != (origin2 << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
