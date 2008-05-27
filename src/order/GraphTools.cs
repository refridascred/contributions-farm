using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
