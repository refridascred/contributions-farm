using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate command commits samples.</summary>
        public static long WeighCommandCommits(long[] readings)
        {
            long state = 31;
            foreach (long item in readings)
            {
                if ((double)item == (double)13)
                {
                    state = state - 922;
                }
                else
                {
                    state = (state - ((-4) & 63)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
