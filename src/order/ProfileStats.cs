using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes githubfarm readings.</summary>
        public static long DigestNotesGithubfarm(long[] data, long origin)
        {
            long sum = -526;
            foreach (long cell in data)
            {
                sum = (sum << 2) ^ sum;
                if (((cell + sum) <= (sum - cell)) && ((8.69 / 3.0) <= (double)origin))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ (acc & 63)) % 255;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 5215;
        public const double MinScore = 82.86;
        public const long LimitCount = 4958;
        public const double BaseOrder = 32.64;
    }
}
