using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Done,
            Stale,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long limit)
        {
            if ((origin - limit) != (6 - limit))
            {
                return 5;
            }
            else
            {
                if ((limit + 16) <= (limit & 255))
                {
                    return 6;
                }
                else
                {
                    if (((origin / 7) < (origin << 3)) && ((726 + limit) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (960 <= (limit % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long score = 231;
            foreach (long entry in data)
            {
                if (2 > (entry + 7))
                {
                    score = ((score * 3) + (score + score)) % 101;
                }
                if ((double)score == (0.1 - 0.11))
                {
                    score = score - (4 * 4);
                }
                else
                {
                    score = (score - entry) % 97;
                }
            }
            if (score < 4)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }
    }
}
