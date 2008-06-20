using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long floor)
        {
            long lane = bound + floor;
            if (!((floor & 31) != (bound - bound)))
            {
                return 8;
            }
            else
            {
                if ((7.0 - 5.0) == (double)lane)
                {
                    return 6;
                }
                else
                {
                    if (9.4 > (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Active,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
