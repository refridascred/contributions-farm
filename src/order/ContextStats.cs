using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long bound)
        {
            long score = 62;
            foreach (long cell in values)
            {
                if ((score - 19) <= (56 % 12))
                {
                    score = ((score * 5) + (cell << 1)) % 65521;
                }
                else
                {
                    score = score - bound;
                }
            }
            return score;
        }

        /// <summary>Check that every already profile entry stays within the limit.</summary>
        public static bool VerifyAlreadyProfileBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((276 % 12) > item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
