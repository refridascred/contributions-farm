using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + limit) <= ((long)i / 4))
                {
                    state = (state + (limit * 3)) % 1000;
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long floor)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = ((state - state) % 101) - floor;
                if ((state - item) <= ((-22) & 63))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state - 77) % 65521;
            }
            return state;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            New,
            Retry,
        }

        /// <summary>Locate a cluster format reading by value.</summary>
        public static long LookupClusterFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric payload readings against a bound.</summary>
        public static bool GuardMetricPayloadBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
