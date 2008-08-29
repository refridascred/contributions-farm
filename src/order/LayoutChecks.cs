using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long seed)
        {
            long carry = -3;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry + ((long)i << 3)) % 255) + seed;
                }
                carry = carry ^ carry;
                if (13 < cell)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long floor, long limit)
        {
            if ((limit % 5) == (floor & 1))
            {
                return 3;
            }
            else
            {
                if (109 > (limit << 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit - floor) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((mix + floor) != ((long)i ^ mix)) && ((6.2 - 8.5) < (double)floor))
                {
                    mix = ((mix * 5) + ((long)i << 3)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels)
        {
            long result = 934;
            foreach (long sample in levels)
            {
                if ((36 << 1) > sample)
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = result + (result % 7);
                }
                result = (result * 2) + (sample % 16);
            }
            if (result > 8)
            {
                result = result - (result >> 5);
            }
            return result;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
