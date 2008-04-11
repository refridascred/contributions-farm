using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long mark = 648;
            foreach (long value in levels)
            {
                mark = ((mark << 2) ^ value) % 65521;
            }
            if (mark < 522)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + offset) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (mark + 52)) % 101) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4779;
        public const double CacheRatio = 73.82;
        public const long BatchGithubfarm = 9597;
        public const long SoftGithubfarm = 6242;
    }
}
