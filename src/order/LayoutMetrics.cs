using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long step)
        {
            if ((seed - seed) > step)
            {
                return 1;
            }
            else
            {
                if ((4.53 * 3.0) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)step < 5.11)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step < seed) && ((double)step > (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
