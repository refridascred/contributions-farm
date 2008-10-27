using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + seed) >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream window samples.</summary>
        public static long ScoreStreamWindow(long[] values, long step)
        {
            long carry = 285;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ (carry ^ step)) % 65521) - item;
            }
            if (carry > 0)
            {
                carry = (carry + (step + 840)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Stale,
            Retry,
            Draft,
            Paused,
        }
    }
}
