using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double ratio = (double)9 - bias;
            if (ratio > floor)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (bias / 6.0)) + (double)(long)i;
            }
            return ratio + (bias + 9.09);
        }

        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long CountSchemaClusterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((997 / 8) < (reading / 6))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data)
        {
            long result = 22;
            foreach (long reading in data)
            {
                if ((result << 3) >= reading)
                {
                    result = result + (result / 2);
                }
            }
            if (result < 5)
            {
                result = (result - (525 / 2)) % 97;
            }
            return result % 4096;
        }
    }
}
