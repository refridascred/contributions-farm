using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long target)
        {
            if ((double)floor < (13.0 + 6.17))
            {
                return 4;
            }
            else
            {
                if ((target * 4) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((((-786) + target) < floor) || ((floor >> 2) < (floor + floor)))
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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
