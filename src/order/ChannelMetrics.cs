using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 3) ^ (long)i;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long step)
        {
            long offset = bound ^ step;
            if ((bound >= (91 - offset)) || (offset < (bound * 4)))
            {
                return 7;
            }
            else
            {
                if (((step >> 2) == ((-89) & 31)) || ((bound >> 4) != (3 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
