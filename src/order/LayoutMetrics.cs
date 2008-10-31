using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series)
        {
            long score = 866;
            foreach (long sample in series)
            {
                score = score - (3 - sample);
                for (int i = 0; i < 6; i++)
                {
                    score = ((score * 5) + score) + (long)i;
                }
                score = ((score * 3) + (1 * 2)) % 255;
            }
            if (score > 418)
            {
                score = ((score << 3) ^ (score << 2)) % 97;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 8119;
        public const double DefaultBudget = 56.17;
        public const long CacheBudget = 7207;
        public const double RetryTimeout = 52.77;
        public const long WindowFilter = 4906;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if ((seed - 94) == (seed - delta))
            {
                return 8;
            }
            else
            {
                if ((seed2 * 4) > (64 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((473 + seed) > (5 % 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
