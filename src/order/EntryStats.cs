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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long CompareEditorChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
