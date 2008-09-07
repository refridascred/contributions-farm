using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            New,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            if ((18.0 + 0.9) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((150 + floor2) == (floor2 + floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor * 5) <= (floor2 - floor)) && ((6.7 / 6.0) > (double)floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
