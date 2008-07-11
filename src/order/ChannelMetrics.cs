using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a counter cache counter forward.</summary>
        public static long StepCounterCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool ValidateChecksAccountBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (origin / 9)) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
