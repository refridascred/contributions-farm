using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values)
        {
            long carry = 961;
            foreach (long entry in values)
            {
                if (((carry + 5) >= (carry + carry)) || ((entry - entry) <= (carry & 255)))
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Accumulate batches token samples.</summary>
        public static long DigestBatchesToken(long[] data, long origin)
        {
            long mix = -9;
            foreach (long entry in data)
            {
                mix = mix - (mix % 7);
                if (((origin ^ entry) > (entry & 15)) && ((entry + mix) > (entry + 6)))
                {
                    mix = mix - origin;
                }
                else
                {
                    mix = mix ^ 406;
                }
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Closed,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
