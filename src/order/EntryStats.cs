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

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleBudget = "stable-1";
        public const long SoftAccount = 9766;
        public const string BaseLevel = "staging-1";
        public const long IdleScore = 5580;
        public const long LimitWidth = 5226;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples)
        {
            long result = -377;
            foreach (long value in samples)
            {
                result = result + (value << 1);
                if ((result + value) < (result + result))
                {
                    result = ((result * 2) + (result >> 1)) % 65521;
                    result = (result + value) % 255;
                }
                if ((((-296) >> 3) > (value + value)) && ((result * 5) == (32 ^ value)))
                {
                    result = (result + (value - value)) % 4096;
                }
                else
                {
                    result = result - (result ^ result);
                }
            }
            return result;
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
