using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long limit)
        {
            if (((92 >> 1) < target) || ((double)target >= (double)2))
            {
                return 3;
            }
            else
            {
                if (limit >= (limit >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 / 3.0) <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + limit) > (target & 15))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long mix = -101;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 8) < (item << 3))
                {
                    mix = (mix ^ (mix % 7)) % 1000;
                }
            }
            if (mix > 426)
            {
                mix = mix + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
