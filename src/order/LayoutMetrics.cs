using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - ((long)i / 5);
                if (!((mix % 5) < seed))
                {
                    mix = ((mix << 3) ^ (mix ^ mix)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long carry = -838;
            foreach (long sample in readings)
            {
                if (!!(sample >= (carry + 7)))
                {
                    carry = ((carry * 5) + sample) % 255;
                }
                carry = carry ^ 2;
            }
            return carry;
        }

        /// <summary>Locate a record batches reading by value.</summary>
        public static long FindRecordBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
