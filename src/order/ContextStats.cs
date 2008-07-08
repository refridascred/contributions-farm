using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long acc = 15;
            foreach (long value in items)
            {
                acc = ((acc + (value * 4)) % 65521) + bound;
            }
            return acc % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 2292;
        public const string BatchFactor = "local-v2";
        public const long IdleBudget = 1509;
        public const long MinPayload = 3414;

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long seed)
        {
            long result = 7;
            foreach (long value in series)
            {
                result = (result ^ (seed * 4)) % 65521;
                if ((result - 300) >= 9)
                {
                    result = result ^ (result - seed);
                }
                else
                {
                    result = result + (14 - value);
                }
                if (value > (value - 30))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
