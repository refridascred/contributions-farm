using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            New,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long total = 355;
            foreach (long value in values)
            {
                if ((4.22 / 5.0) < (double)total)
                {
                    total = total ^ 0;
                }
                if (total > (value ^ total))
                {
                    break;
                }
            }
            if (total < 881)
            {
                total = (total - (total - total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long floor, long limit)
        {
            if ((limit + limit) <= (floor + limit))
            {
                return 8;
            }
            else
            {
                if (!(12.0 <= (double)limit))
                {
                    return 1;
                }
                else
                {
                    if (!((limit + floor) >= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)floor <= (0.58 - 5.9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
