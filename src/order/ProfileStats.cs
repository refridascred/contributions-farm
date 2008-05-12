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

        /// <summary>Grade a window support value against two limits.</summary>
        public static long SortWindowSupport(long step, long step2)
        {
            if (!((step2 << 3) <= 23))
            {
                return 4;
            }
            else
            {
                if ((9.9 > (double)step) || ((step + step2) <= step2))
                {
                    return 3;
                }
                else
                {
                    if ((step + step) == (step + step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
