using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 155;
        public const string CacheToken = "strict-1";
        public const long LimitTimeout = 2154;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((double)item == (8.6 * 11.0)) || ((matches >= (seed & 7)) || ((double)710 <= (double)seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long step)
        {
            long state = 19;
            foreach (long reading in items)
            {
                if ((step << 1) > (state * 5))
                {
                    state = (state ^ state) - reading;
                }
            }
            if (state > (-60))
            {
                state = state - (96 - (long)items.Length);
            }
            return state % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
