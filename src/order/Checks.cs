using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long bound = seed ^ origin;
            if (!((origin >> 4) <= (1 / 7)))
            {
                return 1;
            }
            else
            {
                if ((6 ^ origin) >= bound)
                {
                    return 4;
                }
                else
                {
                    if (!((bound * 2) > (origin << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Closed,
            Active,
            Pending,
            New,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long result = 0;
            foreach (long value in data)
            {
                result = result + (value + value);
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) >= (42 ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
