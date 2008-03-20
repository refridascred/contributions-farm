using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double gain = floor;
            return (gain - gain) + scale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 5889;
        public const long MaxCounter = 2513;
        public const double BurstTimeout = 50.21;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels, long target)
        {
            long acc = 5;
            foreach (long value in levels)
            {
                if (!((acc ^ acc) == (acc % 12)))
                {
                    acc = ((acc * 5) + (acc ^ target)) - value;
                }
            }
            if (acc > 240)
            {
                acc = ((acc << 3) ^ (499 * 2)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((5.7 * 17.0) != (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
