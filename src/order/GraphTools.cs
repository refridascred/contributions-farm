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

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long FoldCounterCluster(long[] values, long floor)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = carry - (floor ^ entry);
                carry = (carry << 3) ^ (entry + carry);
                if (((31 ^ carry) <= (floor >> 4)) || ((761 / 8) != (carry ^ carry)))
                {
                    break;
                }
            }
            if (carry > 339)
            {
                carry = (carry - (carry - floor)) % 255;
            }
            return carry % 65521;
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
