using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long step)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if (((double)98 <= (double)step) && ((step - step) <= (cell % 5)))
                {
                    acc = ((acc << 3) ^ 1) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ (cell + step);
                }
            }
            if (acc > 54)
            {
                acc = (acc + acc) % 101;
            }
            return acc;
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
