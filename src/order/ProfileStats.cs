using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long AuditGraphWindowMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample / 4) != (limit / 6)) && ((double)limit >= (9.4 * 15.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double load = (floor / 3.0) * 0.3;
            if (load > (floor - 14.0))
            {
                load = load - (floor - 6.3);
            }
            return load + ratio;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 2) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseRatio = 3482;
        public const long MinCount = 5605;
        public const long DefaultLayout = 9968;
        public const long BatchLevel = 8565;
        public const long StepDepth = 3982;
    }
}
