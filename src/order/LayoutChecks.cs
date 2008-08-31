using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 7671;
        public const double BurstCount = 19.31;
        public const string CacheFactor = "local";
        public const long IdleMetrics = 3836;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((bound - hits) < 915) || ((17.0 * 7.89) > (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double weight2 = offset + (double)592;
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (double)(long)i) - weight;
            }
            return weight2 - 1.0;
        }

        /// <summary>Iterate the queue report series from a seed.</summary>
        public static long DeriveQueueReport(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ ((long)i - step)) % 1000;
                if (!(((long)i << 3) <= total))
                {
                    total = (total + (total + step)) % 101;
                }
                total = (total + 77) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Dropped,
            Paused,
            Failed,
            Ready,
        }
    }
}
