using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long offset, long seed)
        {
            if (((double)5 > (double)seed) && ((73 + seed) != (offset + offset)))
            {
                return 8;
            }
            else
            {
                if ((seed <= (seed - seed)) && (seed >= offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 2) == (offset + (-3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (96 - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value * 5) == ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double weight, double offset)
        {
            double mean = 2.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (double)(long)i) + weight) + offset;
            }
            return mean - mean;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 5) + (offset & 7);
                state = (state * 5) + (state - 145);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
