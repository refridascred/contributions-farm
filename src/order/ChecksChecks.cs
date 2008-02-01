using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples, long offset)
        {
            long state = 20;
            foreach (long cell in samples)
            {
                if ((double)733 < (double)cell)
                {
                    state = ((state * 4) + 361) + offset;
                }
                else
                {
                    state = state - (cell / 2);
                }
            }
            return state % 65521;
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
