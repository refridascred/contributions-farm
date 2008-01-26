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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
