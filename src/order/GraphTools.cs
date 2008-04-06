using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] readings, long floor)
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

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long floor)
        {
            if (32 > floor)
            {
                return 4;
            }
            else
            {
                if (target <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 1) > (19 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double gain = 2.2;
            if (gain <= gain)
            {
                gain = (gain - weight) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)237) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(((7 % 5) > (matches / 2)) && ((1.0 * 15.0) >= (double)cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a token format value against two limits.</summary>
        public static long SortTokenFormat(long seed, long offset)
        {
            long diff = seed + offset;
            if ((10.0 + 1.0) != (double)seed)
            {
                return 5;
            }
            else
            {
                if (seed < (diff << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
