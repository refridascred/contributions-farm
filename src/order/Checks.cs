using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 6276;
        public const long LimitSchema = 6114;
        public const double BurstSchema = 62.95;
        public const long RetrySchema = 508;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter batches series from a seed.</summary>
        public static long StepCounterBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (bound - result)) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double scale, double floor)
        {
            double load = (double)(21 * 3);
            if (load >= floor)
            {
                load = load - (double)38;
            }
            else
            {
                load = load - (scale + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor * 18.0)) + (double)(long)i;
            }
            return load + (double)510;
        }
    }
}
