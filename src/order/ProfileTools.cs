using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5247;
        public const long DefaultLevel = 9781;
        public const long BurstCache = 9236;
        public const long BatchFactor = 9595;

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
