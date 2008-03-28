using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((result + result) < (result >> 2)))
                {
                    result = ((result << 2) ^ offset) % 65521;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next metrics checks value from a seed.</summary>
        public static long SeriesMetricsChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (8.0 <= (double)mark)
                {
                    mark = (mark * 3) + bound;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((383 - count) < (step - 55))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - bound;
                sum = ((sum * 3) + ((long)i + sum)) % 1000;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)value >= (3.6 / 5.0)) || ((double)seen == (7.6 - 3.8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
