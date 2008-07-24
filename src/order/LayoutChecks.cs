using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if ((double)limit > 3.0)
            {
                return 5;
            }
            else
            {
                if ((double)612 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit / 3) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long TotalAlreadyRoute(long[] items, long offset)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = (anchor ^ 23) % 1000;
                anchor = anchor - item;
                if (!((double)anchor >= 0.1))
                {
                    anchor = (anchor - (offset + 546)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long step)
        {
            if (((origin - step) < step) || ((origin * 2) != (origin & 63)))
            {
                return 2;
            }
            else
            {
                if (((double)origin > (14.0 * 9.78)) || ((origin << 3) >= (step + origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= 8.98)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(2 > origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 43.54;
        public const long RetryTimeout = 8672;
        public const string BurstSpan = "cached-1";

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSpan = 8767;
        public const long IdleDepth = 3778;
        public const double BaseRoute = 90.38;
    }
}
