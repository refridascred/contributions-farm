using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < (scale2 + scale))
            {
                scale2 = scale2 - (offset / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 + (double)18;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate stream metrics readings against a bound.</summary>
        public static bool ValidateStreamMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheBudget = 968;
        public const long MaxSize = 5373;
        public const long MaxWindow = 2450;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 8159;
        public const string IdleDepth = "open-edge";
        public const long MinCommand = 3132;
        public const double HardCommand = 87.48;
    }
}
