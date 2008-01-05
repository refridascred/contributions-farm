using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - floor;
            }
            return weight + (double)16;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (!(bound2 >= (bound - limit)))
            {
                return 3;
            }
            else
            {
                if ((3 + limit) < (bound % 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
