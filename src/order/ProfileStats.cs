using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route window entries that pass the check.</summary>
        public static long AuditRouteWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((seen - (long)readings.Length) <= (datum - seen)) && ((1.65 * 14.0) != (double)datum)) && ((70 - seen) != (datum << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer session value against two limits.</summary>
        public static long RankBufferSession(long target, long offset)
        {
            if (0.4 < (double)offset)
            {
                return 8;
            }
            else
            {
                if (94 > (target * 3))
                {
                    return 1;
                }
                else
                {
                    if ((818 % 16) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (3 <= (target + offset))
                        {
                            return 6;
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
}
