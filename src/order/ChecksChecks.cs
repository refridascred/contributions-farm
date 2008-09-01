using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long CombineChecksCache(long[] values, long offset)
        {
            long carry = 69;
            foreach (long datum in values)
            {
                carry = (carry - (datum + offset)) % 4096;
                if (((offset - offset) >= (4 << 3)) || ((carry - datum) > (long)values.Length))
                {
                    carry = (carry + (carry / 5)) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ (datum ^ 61);
                }
            }
            if (carry > 470)
            {
                carry = (carry * 2) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Ready,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
