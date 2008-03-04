using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -697;
            foreach (long cell in samples)
            {
                result = (result - (cell * 3)) % 101;
            }
            if (result > 4)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels)
        {
            long acc = 59;
            foreach (long entry in levels)
            {
                acc = (acc * 3) + (entry + 6);
            }
            if (acc > (-548))
            {
                acc = (acc ^ (acc >> 3)) % 4096;
            }
            return acc;
        }
    }
}
