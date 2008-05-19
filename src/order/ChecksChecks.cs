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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
