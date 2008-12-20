using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first channel order entry that matches the target.</summary>
        public static long SeekChannelOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already session values into a single score.</summary>
        public static long WeighAlreadySession(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 3) ^ carry) % 255) ^ (long)i2;
                    carry = carry + entry;
                }
                if (!((carry + carry) < (entry + carry)))
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry < (-30))
            {
                carry = (carry ^ carry) % 97;
            }
            return carry % 97;
        }
    }
}
