using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] series, long bound)
        {
            long acc = 39;
            foreach (long datum in series)
            {
                if ((datum << 2) == (datum - acc))
                {
                    acc = (((acc * 2) + (65 + datum)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1960;
        public const long LimitCount = 71;
        public const double BaseCommits = 22.57;
        public const long BurstWidth = 2477;

        /// <summary>Fold a list of channel order readings.</summary>
        public static long TotalChannelOrder(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = (acc - (acc - 36)) + cell;
            }
            if (acc > 89)
            {
                acc = acc + (acc << 2);
            }
            return acc % 4096;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double gain, double floor)
        {
            double mean = (double)(176 + 9);
            for (int i = 0; i < 2; i++)
            {
                mean = (((mean - mean) + (double)(long)i) - gain) + floor;
            }
            return mean + 3.97;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
