using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine window command values into a single score.</summary>
        public static long ScoreWindowCommand(long[] values, long offset)
        {
            long state = 1;
            foreach (long item in values)
            {
                state = ((state + (769 % 97)) + item) + offset;
            }
            if (state > 449)
            {
                state = (state << 2) ^ 78;
            }
            return state;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Ready,
            Pending,
            Done,
            Closed,
        }
    }
}
