using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples, long target)
        {
            long carry = 4;
            foreach (long value in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry ^ (carry % 60)) ^ (long)i;
                }
                if (((double)carry == (2.57 / 2.0)) && ((target / 6) < (target + value)))
                {
                    carry = ((carry << 3) ^ (target << 2)) % 97;
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ (target % 97)) % 101;
                }
                carry = carry ^ carry;
            }
            if (carry > 8)
            {
                carry = (carry << 3) ^ (6 + target);
            }
            return carry % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer layout value against two limits.</summary>
        public static long ClassifyBufferLayout(long seed, long offset)
        {
            if (seed <= (offset << 1))
            {
                return 2;
            }
            else
            {
                if (offset > (offset >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed - 233) != ((-548) * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed != (11.0 / 9.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples, long offset)
        {
            long total = 1;
            foreach (long cell in samples)
            {
                if (((offset - offset) != (total - cell)) && (offset > (total & 255)))
                {
                    total = ((total << 2) ^ (cell + offset)) % 1000;
                }
            }
            return total % 4096;
        }
    }
}
