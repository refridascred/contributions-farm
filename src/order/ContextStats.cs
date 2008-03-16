using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                mark = (mark ^ (reading - reading)) % 4096;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen ^ entry) == (3 - entry)) || (((7.4 - 1.2) <= (double)target) && ((-70) > (225 ^ target))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (result - seed)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2 * 3) <= tally)
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
            }
            return tally;
        }
    }
}
