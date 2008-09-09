using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long target2)
        {
            if ((-2) <= (target2 - 69))
            {
                return 4;
            }
            else
            {
                if ((target2 * 3) > (target2 & 15))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank record githubfarm input into a small class.</summary>
        public static long BucketRecordGithubfarm(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if (bound2 >= (bound + bound2))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 12) < bound2)
                {
                    return 6;
                }
                else
                {
                    if ((slot / 7) > (51 ^ bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (slot <= (bound >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long anchor = 613;
            foreach (long item in items)
            {
                if (item >= (5 % 12))
                {
                    anchor = anchor ^ (item >> 3);
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples)
        {
            long anchor = 1;
            foreach (long cell in samples)
            {
                if (!((12.0 - 3.0) >= (double)cell))
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            if (anchor < (-587))
            {
                anchor = ((anchor * 4) + (63 ^ anchor)) % 65521;
            }
            return anchor;
        }
    }
}
