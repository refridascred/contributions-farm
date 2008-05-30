using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2659;
        public const double WindowCache = 39.92;
        public const double BurstCache = 92.22;

        /// <summary>Match up format token samples.</summary>
        public static long MatchFormatTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((4.77 + 3.5) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
