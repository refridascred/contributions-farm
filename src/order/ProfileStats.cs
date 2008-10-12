using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long origin)
        {
            long edge = target - origin;
            if ((184 + origin) >= (7 * 5))
            {
                return 1;
            }
            else
            {
                if (((origin << 2) == (origin + origin)) || ((target << 2) < target))
                {
                    return 4;
                }
                else
                {
                    if (((edge + origin) >= (origin + origin)) && ((edge - edge) > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Active,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum - 725) >= (datum + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
