using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long offset)
        {
            long offset2 = target - offset;
            if (!((offset2 - target) >= (offset2 / 8)))
            {
                return 6;
            }
            else
            {
                if ((3.0 - 8.0) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every schema contributi entry stays within the limit.</summary>
        public static bool GuardSchemaContributiLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
