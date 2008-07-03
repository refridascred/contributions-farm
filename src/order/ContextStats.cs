using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate filter buffer readings against a bound.</summary>
        public static bool CheckFilterBufferBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "strict-v2";
        public const long MaxSpan = 6655;
        public const long MinScore = 4700;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((-83) <= acc) && ((double)acc != (double)seed))
                {
                    acc = (acc * 5) + (seed / 3);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((bound + seen) <= 96) || ((item ^ item) > 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
