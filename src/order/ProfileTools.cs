using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double bias = (double)(-823) - scale;
            if (bias > (double)(-2))
            {
                bias = (bias + 0.97) - floor;
            }
            return bias + scale;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)total <= (double)origin)
                {
                    total = (total << 3) ^ (origin - (long)i);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6614;
        public const double IdleTimeout = 24.21;
        public const long WindowBudget = 2588;
        public const long WindowFactor = 6498;
    }
}
