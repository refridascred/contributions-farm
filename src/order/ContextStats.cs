using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a layout counter sample.</summary>
        public static long FindLayoutCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - ((long)i / 7)) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark ^ ((long)i + mark)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a queue command counter forward.</summary>
        public static long DeriveQueueCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long count = seed - (seed - 892);
                    sum = (((sum << 2) ^ (count - sum)) % 4096) - (long)i2;
                }
                if ((sum + sum) > (-366))
                {
                    sum = (sum + (seed * 2)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
