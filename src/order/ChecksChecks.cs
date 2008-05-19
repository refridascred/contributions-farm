using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading <= (bound + 469))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
