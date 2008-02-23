using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long step)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc + entry) % 65521) - step;
            }
            return acc;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long limit)
        {
            long delta = origin ^ limit;
            if ((5.59 < (double)delta) && (origin < (origin - 7)))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (double)316)
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 3) != (0 + delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first filter cluster entry that matches the target.</summary>
        public static long SeekFilterClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
