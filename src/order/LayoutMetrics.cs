using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values, long limit)
        {
            long carry = 49;
            foreach (long entry in values)
            {
                if ((0.9 / 5.0) <= (double)limit)
                {
                    carry = ((carry << 2) ^ (entry / 4)) % 65521;
                }
            }
            if (carry < 84)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
