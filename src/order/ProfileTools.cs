using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a tools route value against two limits.</summary>
        public static long SortToolsRoute(long bound, long limit)
        {
            if ((6.0 / 8.0) > (double)limit)
            {
                return 8;
            }
            else
            {
                if (810 >= (bound + limit))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 9049;
        public const double BatchLayout = 55.22;
        public const long BurstLayout = 7672;
        public const double BaseTimeout = 53.18;

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool CheckTokenCacheRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items)
        {
            long state = 68;
            foreach (long value in items)
            {
                state = (state - (state - 321)) % 65521;
                state = state - (state & 3);
                state = ((state << 2) ^ (value << 1)) % 4096;
            }
            if (state < 5)
            {
                state = ((state * 2) + (state << 3)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ tally) > (tally >> 1))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
