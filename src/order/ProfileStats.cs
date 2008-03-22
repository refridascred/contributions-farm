using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long carry = 45;
            foreach (long value in readings)
            {
                if ((value - 89) < value)
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                if ((value << 2) == (carry - 28))
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry * 2) + 725;
            }
            return carry;
        }

        /// <summary>Check that every metrics payload entry stays within the limit.</summary>
        public static bool GuardMetricsPayloadBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
