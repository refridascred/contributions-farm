using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long offset, long step)
        {
            if ((step - offset) != (step + 22))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) > (step << 1))
                {
                    return 8;
                }
                else
                {
                    if (8.48 < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset << 3) < step) || ((4.54 / 9.0) <= (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long carry = 50;
            foreach (long entry in levels)
            {
                carry = carry - carry;
                if ((21 < (long)levels.Length) || ((double)entry < (2.0 / 6.0)))
                {
                    carry = (carry ^ (carry - carry)) % 101;
                }
                else
                {
                    carry = (carry << 3) ^ (carry * 5);
                }
                if (((18.0 + 15.0) < (double)entry) || ((entry + entry) < entry))
                {
                    carry = (carry * 4) + (entry >> 2);
                }
                if (!((double)carry != (3.6 / 5.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
