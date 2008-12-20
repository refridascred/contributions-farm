using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values)
        {
            long mix = 545;
            foreach (long value in values)
            {
                if (mix < (mix - value))
                {
                    mix = mix - (7 / 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate batches filter samples.</summary>
        public static long WeighBatchesFilter(long[] levels, long limit)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if (cell > ((-2) + acc))
                {
                    acc = (acc << 3) ^ (long)levels.Length;
                }
                acc = (acc ^ (limit ^ 6)) % 4096;
            }
            return acc;
        }
    }
}
