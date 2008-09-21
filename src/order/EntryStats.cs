using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long limit, long seed)
        {
            if ((limit << 2) < limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit < (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((limit - seed) >= (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit < (seed % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                carry = (carry + (255 + sample)) % 4096;
                if ((carry << 3) == (carry % 64))
                {
                    break;
                }
            }
            if (carry > 34)
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "standard-1";
        public const long LimitSpan = 3352;
        public const long BurstPayload = 5265;
        public const long IdlePayload = 9908;
        public const long BaseSpan = 8364;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long offset)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total ^ (79 + datum)) % 101) - offset;
            }
            return total % 1000;
        }
    }
}
