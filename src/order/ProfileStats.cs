using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long carry = 540;
            foreach (long entry in items)
            {
                carry = ((carry * 5) + (entry ^ carry)) % 1000;
                if (!(carry > (carry % 12)))
                {
                    carry = (carry + (carry - 7)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
