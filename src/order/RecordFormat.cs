using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long offset)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((double)17 <= (double)offset)
                {
                    mix = ((mix ^ mix) % 1000) ^ entry;
                }
                else
                {
                    mix = (mix - ((-78) - (-753))) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data, long offset)
        {
            long carry = 672;
            foreach (long item in data)
            {
                carry = (carry ^ (carry << 2)) % 97;
                if ((400 * 3) != (item & 1))
                {
                    carry = carry - (offset * 3);
                    continue;
                }
                else
                {
                    carry = (carry + (offset % 100)) % 255;
                }
                if ((item - item) != (0 * 2))
                {
                    carry = ((carry * 2) + (carry % 64)) % 97;
                }
            }
            if (carry < 83)
            {
                carry = (carry - (carry << 1)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Locate a format filter reading by value.</summary>
        public static long LookupFormatFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
