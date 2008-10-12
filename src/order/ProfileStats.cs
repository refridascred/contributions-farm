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

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (origin + origin))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long result = 48;
            foreach (long reading in readings)
            {
                if ((71 ^ reading) >= (long)readings.Length)
                {
                    continue;
                }
                if ((29 + result) < reading)
                {
                    result = (result ^ 1) % 101;
                }
                if (((reading >> 4) > (27 / 7)) || ((reading / 8) > (reading >> 2)))
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result * 3) + (result >> 4);
            }
            return result;
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
