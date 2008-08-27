using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleLevel = 668;
        public const long HardFilter = 1788;
        public const double DefaultCount = 9.51;
        public const long SoftFilter = 8072;
        public const double StepInterval = 11.1;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((double)item < (7.97 / 8.0)) && ((double)tally != (20.0 - 4.2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length >= (count % 97))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 1) >= (item >> 5))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
