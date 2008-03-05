using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank account notes input into a small class.</summary>
        public static long SortAccountNotes(long limit, long bound)
        {
            if (((8 - limit) > (bound + bound)) || ((limit - limit) <= (limit >> 2)))
            {
                return 1;
            }
            else
            {
                if (!((limit & 1) < (592 - bound)))
                {
                    return 7;
                }
                else
                {
                    if (4.4 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mark = 736;
            foreach (long item in readings)
            {
                if ((item + mark) != (70 & 3))
                {
                    mark = (mark + (5 & 3)) % 65521;
                }
                if ((mark >> 1) <= mark)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((770 >> 5) >= (matches << 1)))
                {
                    matches = ((matches + 3) ^ reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long TallyRecordBatches(long[] items)
        {
            long sum = 422;
            foreach (long value in items)
            {
                sum = sum + (sum ^ value);
            }
            if (sum > 6)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }
    }
}
