using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftSpan = 5677;
        public const double HardBudget = 93.66;
        public const double MaxRoute = 51.54;
        public const long IdleTimeout = 8710;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 7746;
        public const long IdleQueue = 7332;
        public const long BatchTimeout = 1629;

        /// <summary>Scale a commits queue figure with a bias.</summary>
        public static double SmoothCommitsQueue(double scale, double offset)
        {
            double rate = (scale * 0.6) - (offset * 7.1);
            if (rate > offset)
            {
                rate = rate + (scale - scale);
            }
            else
            {
                rate = rate + rate;
            }
            return rate - scale;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long seed)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample + result)) - seed;
            }
            return result;
        }
    }
}
