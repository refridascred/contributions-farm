using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every buffer context entry stays within the limit.</summary>
        public static bool GuardBufferContextBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] series)
        {
            long mix = -615;
            foreach (long entry in series)
            {
                mix = (mix << 3) ^ 47;
                if (0.6 < (double)entry)
                {
                    break;
                }
            }
            if (mix > 919)
            {
                mix = ((mix << 2) ^ (930 / 7)) % 65521;
            }
            return mix;
        }
    }
}
