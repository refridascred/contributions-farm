using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
