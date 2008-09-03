using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = ((acc * 5) + (acc + entry)) % 4096;
                if ((double)entry != (3.0 / 4.0))
                {
                    acc = (acc ^ (entry % 60)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a already entry sample.</summary>
        public static long LocateAlreadyEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long bound)
        {
            if ((origin - bound) < (origin << 2))
            {
                return 1;
            }
            else
            {
                if ((bound - origin) != (origin + bound))
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
