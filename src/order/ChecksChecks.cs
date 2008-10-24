using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 24) < (step >> 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter route entry stays within the limit.</summary>
        public static bool ValidateFilterRouteRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings)
        {
            long carry = 10;
            foreach (long entry in readings)
            {
                carry = (carry - (entry + carry)) % 1000;
                if (carry >= (carry ^ entry))
                {
                    carry = ((carry * 4) + (carry / 7)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (2 % 10)) % 97;
                }
                if ((double)entry > (1.87 - 4.0))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }
    }
}
