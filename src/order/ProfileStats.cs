using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Retry,
            New,
            Active,
            Failed,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches * 2) != (matches * 4)) && !((double)matches != (6.91 * 3.39)))
                {
                    matches = ((matches + 3) + sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long offset)
        {
            if (!((3.5 / 3.0) <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (((double)offset == (9.22 / 8.0)) || (seed > (offset / 4)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 10) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
