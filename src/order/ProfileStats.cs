using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings)
        {
            long carry = -833;
            foreach (long item in readings)
            {
                if (((carry * 4) == (carry + item)) && ((68 ^ item) <= item))
                {
                    carry = (carry - ((long)readings.Length * 4)) % 1000;
                }
                if ((double)carry >= 5.3)
                {
                    break;
                }
            }
            if (carry < (-6))
            {
                carry = (carry + (843 + carry)) % 4096;
            }
            return carry;
        }
    }
}
