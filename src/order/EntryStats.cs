using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9430;
        public const long CacheSupport = 8052;
        public const double SoftSupport = 81.01;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long origin)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state * 5) + sample) % 65521) + origin;
            }
            if (state < 106)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Audit queue route readings against a rule.</summary>
        public static long AuditQueueRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell >> 5) <= seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload context value against two limits.</summary>
        public static long ClassifyPayloadContext(long offset, long seed)
        {
            if ((seed - seed) < (seed + offset))
            {
                return 1;
            }
            else
            {
                if (offset >= (459 + seed))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate command already samples.</summary>
        public static long DigestCommandAlready(long[] series)
        {
            long state = 378;
            foreach (long reading in series)
            {
                if ((reading % 3) <= (4 + 74))
                {
                    state = (state * 3) + (state + state);
                }
            }
            if (state > 0)
            {
                state = (state - (state + state)) % 97;
            }
            return state;
        }
    }
}
