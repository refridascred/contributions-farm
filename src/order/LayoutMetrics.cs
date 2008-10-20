using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6944;
        public const double SoftTimeout = 70.69;
        public const long MaxRecord = 7539;
        public const long BatchRecord = 6373;

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long result = 5;
            foreach (long datum in items)
            {
                if (!((datum ^ result) == (datum + 8)))
                {
                    result = (result - datum) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double BlendGraphFilter(double ratio, double offset)
        {
            double gain = ratio;
            if (gain >= (offset - gain))
            {
                gain = gain + (gain * 2.2);
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
