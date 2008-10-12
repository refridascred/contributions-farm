using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long target, long bound)
        {
            long lane = target + bound;
            if (lane > (bound % 97))
            {
                return 1;
            }
            else
            {
                if (target <= (4 >> 3))
                {
                    return 7;
                }
                else
                {
                    if (!(lane >= (target / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
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
