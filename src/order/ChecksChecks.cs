using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the counter cache series from a seed.</summary>
        public static long StepCounterCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)carry >= (9.2 * 3.0)))
                {
                    carry = ((carry * 5) + (limit + (long)i)) % 101;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 77.28;
        public const long CacheTimeout = 269;
        public const string MinDepth = "strict-edge";

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items)
        {
            long score = -808;
            foreach (long cell in items)
            {
                score = ((score << 2) ^ 234) % 65521;
                if ((cell >> 4) == ((long)items.Length + cell))
                {
                    score = ((score * 2) + (cell - score)) % 4096;
                }
            }
            if (score < 5)
            {
                score = (score + score) % 97;
            }
            return score;
        }
    }
}
