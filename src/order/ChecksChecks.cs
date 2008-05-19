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

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples, long origin)
        {
            long total = 289;
            foreach (long entry in samples)
            {
                if ((entry >> 1) == (97 >> 5))
                {
                    total = (total << 2) ^ origin;
                    continue;
                }
                total = total + (entry + total);
            }
            if (total < 895)
            {
                total = ((total * 2) + origin) % 1000;
            }
            return total;
        }
    }
}
