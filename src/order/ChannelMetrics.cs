using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long acc = 692;
            foreach (long item in data)
            {
                if ((long)data.Length >= (acc + item))
                {
                    acc = ((acc << 2) ^ item) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (item & 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long floor, long offset)
        {
            long offset2 = floor + offset;
            if (((1 & 127) <= offset2) || ((double)offset2 <= (3.64 - 9.0)))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (7.0 - 5.83))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor <= 3.38)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) != (floor & 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i >= (335 & 255)) && (((long)i - carry) < bound))
                {
                    carry = carry ^ (carry % 12);
                    carry = (carry << 3) ^ carry;
                }
                carry = (carry + carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
