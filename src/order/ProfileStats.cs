using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit buffer order readings against a rule.</summary>
        public static long TallyBufferOrderGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + reading) >= (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long ClassifyChannelCache(long bound, long step)
        {
            long gap = bound - step;
            if ((double)step != (1.0 - 7.96))
            {
                return 8;
            }
            else
            {
                if (!((double)gap <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
