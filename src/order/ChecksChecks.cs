using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of layout format readings.</summary>
        public static long DigestLayoutFormat(long[] readings)
        {
            long state = -4;
            foreach (long datum in readings)
            {
                if ((-4) > (state - state))
                {
                    state = (state * 5) + datum;
                }
            }
            return state % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 9574;
        public const double BaseSchema = 87.13;
        public const string CacheSpan = "open-1";
        public const double WindowRatio = 42.82;
        public const long DefaultScore = 8532;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= 2.48)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
