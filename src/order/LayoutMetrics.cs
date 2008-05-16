using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 8518;
        public const long DefaultCount = 6506;
        public const double DefaultRatio = 53.71;

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long origin)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                if ((origin - 98) < (4 - origin))
                {
                    anchor = (anchor ^ ((-370) ^ reading)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Combine metrics graph values into a single score.</summary>
        public static long WeighMetricsGraph(long[] levels)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                if (0.04 >= (double)total)
                {
                    total = (total ^ (cell + total)) % 97;
                }
                else
                {
                    total = (total * 3) + (total ^ total);
                }
            }
            if (total > 7)
            {
                total = (total + total) % 65521;
            }
            return total % 97;
        }
    }
}
