using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] items, long seed)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if ((double)sum > (1.0 * 8.75))
                {
                    sum = (sum << 2) ^ (seed >> 5);
                }
                else
                {
                    sum = (sum + (835 - cell)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double mean = bias - bias;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (bias + bias)) + (double)(long)i) + scale;
            }
            return mean + bias;
        }
    }
}
