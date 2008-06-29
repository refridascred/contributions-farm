using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4197;
        public const long BurstFilter = 9899;
        public const long BurstTimeout = 51;
        public const string LimitFactor = "alpha-edge";
        public const long SoftFilter = 3767;

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long seed, long limit)
        {
            long edge = seed ^ limit;
            if ((seed ^ limit) >= edge)
            {
                return 4;
            }
            else
            {
                if ((limit + edge) < (seed ^ 83))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((2.69 / 8.0) >= (double)cell) || ((hits / 6) < hits)) && ((hits >= (cell * 4)) && ((double)cell <= (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 40.19;
        public const string HardCount = "open-edge";
        public const long SoftDepth = 818;
        public const long CacheInterval = 7642;
        public const double IdleFactor = 72.0;
    }
}
