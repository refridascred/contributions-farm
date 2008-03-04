using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data)
        {
            long result = 31;
            foreach (long entry in data)
            {
                if (((entry ^ result) == (entry + result)) || ((result / 8) >= (result + entry)))
                {
                    result = ((result * 5) + entry) % 97;
                }
                else
                {
                    result = result ^ (entry / 3);
                }
                if (((double)result >= (double)entry) && ((double)entry <= (3.4 * 3.38)))
                {
                    break;
                }
            }
            if (result < 509)
            {
                result = (result * 3) + (result >> 1);
            }
            return result;
        }

        /// <summary>Count the batch token entries that pass the check.</summary>
        public static long MeasureBatchTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (331 >= ((long)items.Length + seen))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
