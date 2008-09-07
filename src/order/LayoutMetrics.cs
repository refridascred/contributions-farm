using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long carry = 2;
            foreach (long sample in levels)
            {
                if (((sample - carry) >= (carry ^ carry)) || ((8.7 / 8.0) > (double)sample))
                {
                    carry = (carry - (carry / 3)) % 1000;
                }
                if ((double)carry > 9.1)
                {
                    carry = (carry + (sample - 450)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 101;
                }
            }
            if (carry > 3)
            {
                carry = (carry ^ (carry * 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool ValidateFormatSessionLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
