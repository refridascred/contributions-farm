using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long prev = step - limit;
            if ((3.05 - 8.51) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((14.0 / 3.0) < (double)prev)
                {
                    return 0;
                }
                else
                {
                    if (!((4 / 8) < (prev << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((613 < (limit - limit)) && ((step - prev) > (7 + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order contributi entries.</summary>
        public static long DigestOrderContributi(long[] values)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                if ((13.0 * 15.0) <= (double)carry)
                {
                    carry = ((carry << 3) ^ (entry + carry)) % 65521;
                }
                else
                {
                    carry = (carry ^ (carry << 3)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
