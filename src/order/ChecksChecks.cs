using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data, long seed)
        {
            long carry = 279;
            foreach (long value in data)
            {
                carry = ((carry ^ (carry - value)) % 255) + seed;
            }
            if (carry > 6)
            {
                carry = ((carry * 5) + (long)data.Length) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Roll a route window counter forward.</summary>
        public static long SeriesRouteWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = carry - ((long)i >> 5);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
