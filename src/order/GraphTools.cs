using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank queue layout input into a small class.</summary>
        public static long BucketQueueLayout(long floor, long target)
        {
            if ((target + target) == (floor * 3))
            {
                return 1;
            }
            else
            {
                if (6.3 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 255) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
