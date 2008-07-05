using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ result) % 65521;
                result = result + (limit + 0);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series, long step)
        {
            long sum = 98;
            foreach (long item in series)
            {
                sum = ((sum ^ item) % 4096) - step;
            }
            return sum;
        }
    }
}
