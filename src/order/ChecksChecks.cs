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

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series, long limit)
        {
            long sum = -6;
            foreach (long entry in series)
            {
                sum = ((sum ^ sum) % 65521) ^ entry;
                if (((-6) * 4) != (sum % 7))
                {
                    sum = ((sum * 3) + (limit << 2)) % 1000;
                }
            }
            return sum;
        }

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
