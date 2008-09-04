using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((10.0 * 6.0) <= (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit editor contributi readings against a rule.</summary>
        public static long CountEditorContributiGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((58 & 255) <= (datum * 2))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }
    }
}
