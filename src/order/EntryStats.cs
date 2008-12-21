using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long origin, long target)
        {
            if (!(target < (origin + target)))
            {
                return 3;
            }
            else
            {
                if (!((target * 4) > (target << 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((target ^ origin) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (98 < (target + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            New,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long total = 548;
            foreach (long item in series)
            {
                total = total - (item >> 1);
                total = (total ^ (item + origin)) % 65521;
                if (origin < (total + total))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 68)
            {
                total = (total + (total / 7)) % 97;
            }
            return total % 4096;
        }
    }
}
