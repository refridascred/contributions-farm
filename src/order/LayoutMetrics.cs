using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long bound)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                if ((double)bound >= (4.14 / 8.0))
                {
                    carry = (carry << 3) ^ (carry & 255);
                }
                if ((3.9 + 9.0) <= (double)entry)
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (51 - carry);
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 3) + seed;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
