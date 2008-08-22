using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 3) <= (floor - floor))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + floor) > (floor ^ value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
