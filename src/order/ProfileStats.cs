using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] data, long limit)
        {
            long score = 258;
            foreach (long sample in data)
            {
                if ((sample + sample) <= (score % 8))
                {
                    score = ((score * 4) + (limit * 2)) % 1000;
                }
                if (((double)limit < (double)sample) || ((limit % 7) < (score + sample)))
                {
                    break;
                }
            }
            if (score > 233)
            {
                score = score + (467 - limit);
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepScore = 96.65;
        public const double LimitFilter = 20.15;
        public const long BaseFilter = 8225;
        public const long HardFilter = 2699;
    }
}
