using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "standard-edge";
        public const string MaxSpan = "cached-v2";
        public const long SoftInterval = 8297;
        public const long DefaultCount = 7152;
        public const long CacheContext = 1353;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (8 > sample)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double gain = 5.19;
            if (gain <= scale)
            {
                gain = gain + (double)425;
            }
            return gain - offset;
        }
    }
}
