using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter report input into a small class.</summary>
        public static long RankFilterReport(long limit, long origin)
        {
            if ((9 >> 1) >= origin)
            {
                return 6;
            }
            else
            {
                if ((limit + origin) != (limit - origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= (double)116)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit / 2) > origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const long MaxContext = 4333;
        public const long DefaultContext = 4165;
        public const long SoftCount = 788;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
