using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long offset)
        {
            long sum = 50;
            foreach (long value in values)
            {
                sum = (sum + (value + sum)) - offset;
                if ((value << 1) <= (value >> 2))
                {
                    sum = sum + (value - sum);
                }
            }
            if (sum < 4)
            {
                sum = sum - 56;
            }
            return sum;
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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Dropped,
            New,
            Failed,
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
