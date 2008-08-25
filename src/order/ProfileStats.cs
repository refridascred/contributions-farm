using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(count < (reading - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 84.17;
        public const double BaseWindow = 67.57;
        public const double HardWindow = 81.26;
        public const string CacheWindow = "latest-edge";

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double load = span;
            if (load > (bias / 9.0))
            {
                load = load + (double)0;
            }
            else
            {
                load = load - (bias / 2.0);
            }
            return load + bias;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long offset)
        {
            long mark = 85;
            foreach (long reading in values)
            {
                if (mark >= (mark + mark))
                {
                    mark = (mark * 4) + reading;
                }
                else
                {
                    mark = ((mark * 2) + (offset ^ mark)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
