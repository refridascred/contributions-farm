using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long step)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                if (((cell + cell) >= (anchor - anchor)) || ((20.0 + 5.0) <= (double)anchor))
                {
                    anchor = anchor ^ (step ^ cell);
                }
            }
            if (anchor > 761)
            {
                anchor = (anchor << 2) ^ step;
            }
            return anchor % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values)
        {
            long carry = 83;
            foreach (long value in values)
            {
                carry = carry - value;
            }
            if (carry > 894)
            {
                carry = (carry - (carry * 2)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
