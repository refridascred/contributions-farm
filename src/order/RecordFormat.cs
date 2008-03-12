using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Closed,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long StepBatchesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long seed)
        {
            if (!((5.2 - 0.65) > (double)bound))
            {
                return 4;
            }
            else
            {
                if (seed < (seed ^ bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window contributi value.</summary>
        public static double BlendWindowContributi(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + floor) - (double)(long)i;
            }
            return gain2 - (0.28 - floor);
        }
    }
}
