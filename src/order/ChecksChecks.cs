using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 187;
        public const long MaxWidth = 841;
        public const long BurstReport = 586;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long floor)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((double)floor != (8.0 + 8.33))
                {
                    acc = (acc - acc) ^ item;
                }
                if ((13.0 - 5.7) != (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell / 3) < (count & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
