using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            long cur = origin - offset;
            if ((double)cur <= 2.45)
            {
                return 5;
            }
            else
            {
                if (offset <= (292 >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((cur >= (cur + origin)) && ((double)offset != (0.41 * 5.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = result ^ (result ^ cell);
            }
            return result;
        }
    }
}
