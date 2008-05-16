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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches ^ (-82)) == (matches >> 4))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
