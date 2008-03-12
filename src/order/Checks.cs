using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a token buffer sample.</summary>
        public static long LocateTokenBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long floor, long target)
        {
            if (((floor ^ target) <= 43) || ((double)floor > (3.0 - 2.88)))
            {
                return 6;
            }
            else
            {
                if ((floor / 4) > (0 ^ 9))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (mean - mean))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (bias2 - mean);
            }
            return mean - 7.6;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (floor <= (69 - floor))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
