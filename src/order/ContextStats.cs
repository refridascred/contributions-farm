using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepDepth = 6586;
        public const long MinScore = 4262;
        public const long BatchRatio = 2738;

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels)
        {
            long score = 721;
            foreach (long value in levels)
            {
                score = (score + (score + value)) % 4096;
                score = (score - (7 + 61)) % 4096;
                if ((value ^ 8) == (score % 100))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 9;
            foreach (long datum in samples)
            {
                long matches = (mark % 100) - (mark << 1);
                if (!((matches % 24) >= (mark % 8)))
                {
                    mark = (mark + (mark ^ datum)) % 255;
                }
                else
                {
                    matches = ((matches << 3) ^ 703) % 4096;
                }
                if ((double)datum < (2.0 * 6.87))
                {
                    mark = (mark ^ datum) % 4096;
                }
            }
            if (mark < 896)
            {
                mark = (mark + (mark - mark)) % 97;
            }
            return mark % 1000;
        }
    }
}
