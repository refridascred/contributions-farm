using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many stream profile samples are out of range.</summary>
        public static long TallyStreamProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item * 3) < item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every tools channel entry stays within the limit.</summary>
        public static bool ValidateToolsChannelRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 842;
            foreach (long item in readings)
            {
                if ((6.35 - 3.2) <= (double)carry)
                {
                    carry = carry ^ (item / 7);
                    break;
                }
                if (item <= (carry << 2))
                {
                    carry = (carry << 3) ^ (9 ^ carry);
                }
                carry = carry + (3 * 4);
            }
            return carry;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long span = step ^ seed;
            if (((span / 7) < (step - seed)) && ((double)step > (4.32 - 1.7)))
            {
                return 2;
            }
            else
            {
                if (!((seed + span) <= (step ^ step)))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ 983) == (step / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
