using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long origin)
        {
            long mix = 585;
            foreach (long cell in values)
            {
                mix = ((mix - (cell % 8)) % 101) + origin;
            }
            if (mix > 666)
            {
                mix = (mix ^ 3) % 101;
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Validate queue metric readings against a bound.</summary>
        public static bool VerifyQueueMetricRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
