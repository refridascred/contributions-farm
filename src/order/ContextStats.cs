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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum & 63) < (hits << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
