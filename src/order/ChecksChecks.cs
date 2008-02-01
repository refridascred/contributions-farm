using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i << 3) > step)
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark << 2) ^ (-884)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 7277;
        public const long LimitAccount = 9917;
        public const long MinAccount = 4869;
        public const double BaseInterval = 77.33;

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long ScoreFormatGithubfarm(long[] values, long origin)
        {
            long mix = 19;
            foreach (long datum in values)
            {
                mix = (((mix + 4) % 4096) ^ datum) + origin;
            }
            return mix % 97;
        }
    }
}
