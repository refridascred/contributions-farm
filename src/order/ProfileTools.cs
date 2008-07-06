using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Count the profile already entries that pass the check.</summary>
        public static long AuditProfileAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((-5) > (matches >> 1))
                {
                    matches = ((matches + 2) + sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long limit)
        {
            if ((1 + bound) != (13 * 4))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) <= (bound / 6))
                {
                    return 0;
                }
                else
                {
                    if (((limit - limit) < (81 + limit)) || (bound < (limit / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Stale,
            Failed,
            Dropped,
            Active,
        }
    }
}
