using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 3) == (cell & 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload format value from a seed.</summary>
        public static long SeriesPayloadFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 83;
            foreach (long cell in series)
            {
                mark = mark + (cell + cell);
                if (((double)cell != (2.0 - 8.12)) || (573 >= mark))
                {
                    mark = (mark - mark) % 4096;
                    continue;
                }
                mark = ((mark << 2) ^ 31) % 97;
            }
            return mark % 4096;
        }
    }
}
