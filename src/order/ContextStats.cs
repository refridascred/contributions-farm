using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleScore = "latest-edge";
        public const long LimitSize = 1858;
        public const long LimitRoute = 3446;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((seen / 5) > 714) && ((seen % 5) <= cell)) && (((cell & 15) >= seen) && ((cell + cell) > (seen + cell))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor + (anchor + anchor)) % 255) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 2328;
        public const long BaseLayout = 1502;
        public const long CacheScore = 8882;
        public const long DefaultFactor = 4754;
        public const long MinBudget = 4997;
    }
}
