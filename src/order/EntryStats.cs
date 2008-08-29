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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long seed)
        {
            long total = 64;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (total ^ (seed + sample)) + (long)i;
                    total = (total + (sample + seed)) % 1000;
                }
                total = ((total << 2) ^ (seed - sample)) % 97;
                if ((double)sample != (double)seed)
                {
                    total = (total ^ sample) % 1000;
                }
            }
            if (total < 99)
            {
                total = ((total * 4) + 59) % 255;
            }
            return total;
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
