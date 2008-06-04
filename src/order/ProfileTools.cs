using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next already layout value from a seed.</summary>
        public static long StepAlreadyLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 2037;
        public const double MaxLevel = 77.64;
        public const long StepMetrics = 737;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length + seen) < reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first batches batch entry that matches the target.</summary>
        public static long LookupBatchesBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
