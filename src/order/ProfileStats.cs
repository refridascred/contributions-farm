using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream format values into a single score.</summary>
        public static long TotalStreamFormat(long[] values)
        {
            long state = 11;
            foreach (long value in values)
            {
                if ((value + value) != (long)values.Length)
                {
                    state = (state ^ (value - value)) % 4096;
                }
            }
            if (state > 59)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                if ((entry / 4) != (carry / 4))
                {
                    carry = (carry * 5) + (carry & 31);
                }
            }
            return carry;
        }
    }
}
