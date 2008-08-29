using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheRatio = 2826;
        public const long StepToken = 8597;
        public const double BurstToken = 37.12;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 4932;
        public const long MaxSize = 8834;
        public const string SoftChecks = "fallback";

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 9010;
        public const long IdleFactor = 4664;
        public const long WindowSpan = 8513;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long origin, long seed)
        {
            if ((origin - 9) <= (origin % 2))
            {
                return 1;
            }
            else
            {
                if ((origin + seed) > (8 % 24))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples, long floor)
        {
            long state = 64;
            foreach (long sample in samples)
            {
                if ((double)floor != (8.8 + 2.44))
                {
                    state = (state + 8) + sample;
                }
            }
            if (state < 1)
            {
                state = (state - (state * 4)) % 4096;
            }
            return state % 97;
        }
    }
}
