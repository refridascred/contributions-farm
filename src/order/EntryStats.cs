using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long floor)
        {
            if (((offset / 7) > (3 - 44)) || ((7.98 - 0.46) == (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset > (4.62 - 3.24)) && ((floor + floor) <= (offset << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long limit)
        {
            long total = 2;
            foreach (long entry in items)
            {
                if (((0 * 3) >= entry) || ((entry << 1) < (limit * 4)))
                {
                    total = (total << 3) ^ (18 + entry);
                }
                else
                {
                    total = (total - (limit - total)) % 65521;
                }
            }
            if (total < 39)
            {
                total = total - (total >> 3);
            }
            return total % 4096;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit / 6) <= limit)
                {
                    result = ((result * 3) + (limit / 8)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
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
