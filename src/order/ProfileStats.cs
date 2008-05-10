using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long carry = 25;
            foreach (long item in items)
            {
                carry = ((carry - ((-946) >> 3)) % 1000) - item;
            }
            return carry;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long mix = -8;
            foreach (long cell in values)
            {
                mix = (mix * 2) + (mix / 3);
                if (cell > (mix % 10))
                {
                    mix = (mix - (4 + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long seed, long floor)
        {
            if ((double)floor >= (double)seed)
            {
                return 4;
            }
            else
            {
                if (seed > floor)
                {
                    return 2;
                }
                else
                {
                    if (!(13.0 < (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor >= (floor - floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
