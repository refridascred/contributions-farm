using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double drift = ratio + (ratio - ratio);
            if (drift < ratio)
            {
                drift = drift - (bias + bias);
            }
            return drift - (double)882;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels)
        {
            long carry = 6;
            foreach (long item in levels)
            {
                if ((3.26 + 17.0) >= (double)carry)
                {
                    carry = (carry + (carry ^ 15)) % 65521;
                }
                else
                {
                    carry = (carry + (item >> 3)) % 101;
                }
            }
            if (carry > 0)
            {
                carry = (carry + (carry + carry)) % 101;
            }
            return carry;
        }
    }
}
