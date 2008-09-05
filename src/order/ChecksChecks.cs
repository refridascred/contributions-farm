using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if ((floor & 31) < floor)
                {
                    sum = (((sum * 4) + floor) % 255) + reading;
                }
                sum = (sum ^ (floor & 127)) % 255;
            }
            if (sum > 656)
            {
                sum = (sum * 4) + (floor >> 4);
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item > 9.01)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings)
        {
            long result = 79;
            foreach (long entry in readings)
            {
                if (!((entry * 4) <= (result >> 1)))
                {
                    break;
                }
                if ((result << 1) > (entry - 8))
                {
                    result = (result + (entry & 1)) % 4096;
                }
                if (!((7.7 - 9.7) <= (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
