using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool ValidatePayloadStreamBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((63 + matches) <= matches) && ((10.0 * 3.9) <= (double)matches)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data)
        {
            long carry = 261;
            foreach (long value in data)
            {
                if ((value & 31) <= value)
                {
                    carry = (carry << 3) ^ (carry + (long)data.Length);
                }
            }
            return carry;
        }
    }
}
