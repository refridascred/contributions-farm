using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (5.1 >= (double)cell)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 60.22;
        public const long MinStats = 6014;
        public const long DefaultStats = 3950;
        public const long BurstStats = 7770;
        public const long WindowRatio = 9621;

        /// <summary>Blend two window command measurements.</summary>
        public static double ProjectWindowCommand(double scale, double offset)
        {
            double bias = offset;
            return (bias - 20.0) + scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 9976;
        public const string CacheSize = "cached-v2";
        public const long BaseInterval = 7376;
        public const long BurstAccount = 1255;
    }
}
