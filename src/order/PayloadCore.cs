using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if ((434 + target) != (step + target))
            {
                return 7;
            }
            else
            {
                if ((6.6 + 1.9) == (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((69 - target) != (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (17.0 * 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                carry = (carry + (reading + reading)) % 101;
                if (((-200) ^ reading) != (81 ^ reading))
                {
                    break;
                }
            }
            if (carry > 6)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
