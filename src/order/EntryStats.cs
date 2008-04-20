using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the batches graph series from a seed.</summary>
        public static long StepBatchesGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((0.81 / 9.0) >= (double)floor)
                {
                    continue;
                }
                else
                {
                    mix = (mix - ((long)i >> 4)) % 101;
                }
                long diff = (79 / 9) ^ (mix & 127);
                if (floor < diff)
                {
                    diff = diff ^ (mix + diff);
                }
                else
                {
                    diff = (diff ^ (floor << 1)) % 65521;
                    diff = ((diff << 3) ^ ((long)i >> 2)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long step)
        {
            long sum = 637;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((((sum * 2) + (step + sum)) % 255) - (long)i) - reading;
                }
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }
    }
}
