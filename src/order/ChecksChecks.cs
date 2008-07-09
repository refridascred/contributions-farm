using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long floor)
        {
            long step2 = step + floor;
            if ((floor + step2) != (549 << 2))
            {
                return 1;
            }
            else
            {
                if (step <= (step2 - 45))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Measure how many metrics profile samples are out of range.</summary>
        public static long CountMetricsProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches ^ (-45)) <= (2 + entry)) && (entry >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
