using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - (bias / 2.0)) - floor;
            }
            else
            {
                bias2 = bias2 + (4.0 * 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer session values into a single score.</summary>
        public static long CombineBufferSession(long[] items, long seed)
        {
            long total = 55;
            foreach (long item in items)
            {
                if ((seed ^ seed) != (seed / 9))
                {
                    total = ((total + total) % 1000) + item;
                }
                else
                {
                    total = (total + (seed % 12)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
