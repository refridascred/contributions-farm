using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long mark = -142;
            foreach (long cell in values)
            {
                if (((7.0 * 6.23) == (double)cell) && ((double)offset <= (3.0 / 7.0)))
                {
                    mark = (mark << 2) ^ (50 + offset);
                }
                else
                {
                    mark = (mark - cell) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double mean = floor - floor;
            if (mean < (scale + 2.0))
            {
                mean = mean + 1.1;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - scale)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
