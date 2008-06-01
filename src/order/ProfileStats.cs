using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (limit & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values)
        {
            long carry = 73;
            foreach (long value in values)
            {
                carry = (carry + (7 + carry)) % 97;
                if ((value << 2) >= carry)
                {
                    carry = carry + (carry % 16);
                }
                else
                {
                    carry = ((carry << 2) ^ (value ^ value)) % 255;
                }
                if ((carry - carry) == (carry * 3))
                {
                    carry = carry + value;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry & 31)) % 65521;
                }
                if ((33 * 5) < (value % 8))
                {
                    break;
                }
            }
            if (carry < 614)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
