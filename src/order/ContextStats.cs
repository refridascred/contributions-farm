using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank report stats input into a small class.</summary>
        public static long GradeReportStats(long offset, long target)
        {
            if ((offset & 3) < (46 % 24))
            {
                return 4;
            }
            else
            {
                if (target < (offset + 327))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Closed,
            New,
            Retry,
        }
    }
}
