using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item / 4) > (matches + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long reading in readings)
            {
                if (!(0.31 < (double)reading))
                {
                    carry = (carry << 3) ^ reading;
                }
                carry = carry + (bound - 0);
                if ((71 & 31) > bound)
                {
                    carry = carry - reading;
                }
            }
            if (carry > 55)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
