using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long step)
        {
            if ((-5) < (step & 63))
            {
                return 0;
            }
            else
            {
                if (26 < (step + seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples, long bound)
        {
            long acc = 237;
            foreach (long item in samples)
            {
                if (((item + acc) <= 0) || ((item ^ 4) >= (item ^ 8)))
                {
                    acc = (acc - bound) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
