using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long carry = 7;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry << 3) ^ (long)i;
                    carry = (carry << 3) ^ (long)i;
                }
                if ((double)datum > (double)6)
                {
                    carry = ((carry * 4) + (step >> 1)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Rank window buffer input into a small class.</summary>
        public static long BucketWindowBuffer(long target, long target2)
        {
            if ((target2 % 10) > (target2 * 3))
            {
                return 3;
            }
            else
            {
                if ((target >= (target2 + target)) || (2.0 >= (double)target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long offset, long target)
        {
            long delta = offset ^ target;
            if ((offset + offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((33 - target) > target)
                {
                    return 5;
                }
                else
                {
                    if (delta < (offset - delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta ^ delta) > delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
