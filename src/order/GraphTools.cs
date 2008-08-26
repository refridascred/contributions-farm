using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long ScoreContextCache(long[] items, long seed)
        {
            long carry = 8;
            foreach (long sample in items)
            {
                if ((carry + carry) == (seed + 4))
                {
                    carry = (carry - seed) + sample;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long carry = -417;
            foreach (long item in levels)
            {
                carry = (carry ^ (carry - item)) % 4096;
            }
            if (carry > 54)
            {
                carry = carry - (offset * 4);
            }
            return carry;
        }
    }
}
