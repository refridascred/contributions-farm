using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long floor)
        {
            if ((seed - seed) <= (seed ^ floor))
            {
                return 6;
            }
            else
            {
                if (((seed + floor) < floor) && ((double)seed != (9.9 * 0.5)))
                {
                    return 2;
                }
                else
                {
                    if (5.0 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + floor) == (899 % 16))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value ^ seed) > (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long sum = 95;
            foreach (long value in values)
            {
                if ((709 & 1) == (sum - value))
                {
                    sum = (sum ^ value) % 1000;
                }
            }
            if (sum < 47)
            {
                sum = (sum ^ step) % 255;
            }
            return sum;
        }
    }
}
