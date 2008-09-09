using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = ((state * 4) + (66 << 2)) + reading;
            }
            return state % 4096;
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
