using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((5.82 + 7.2) != (double)value) || (matches > (987 - floor))) || ((41 << 3) <= (value + floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count == (2.8 * 9.45))
                {
                    count = ((count + 1) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the already command series from a seed.</summary>
        public static long IterateAlreadyCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
