using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double bias = 15.0 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain * 11.0)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (551 <= (count % 24))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Locate a context account reading by value.</summary>
        public static long LocateContextAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
