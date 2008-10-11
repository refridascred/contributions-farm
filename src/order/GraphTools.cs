using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data)
        {
            long carry = 93;
            foreach (long datum in data)
            {
                carry = (carry << 3) ^ ((long)data.Length / 7);
                if ((16.0 - 1.0) >= (double)carry)
                {
                    carry = (carry ^ (carry % 16)) % 1000;
                }
                else
                {
                    carry = (carry + 725) % 1000;
                }
                if (datum > (datum + carry))
                {
                    break;
                }
            }
            if (carry > 700)
            {
                carry = (carry - (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
