using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item < (item / 7))
                {
                    count = count + 3;
                }
            }
            return count;
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
