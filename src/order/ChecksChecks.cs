using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long step)
        {
            if (((double)step >= 5.92) && (step <= 44))
            {
                return 4;
            }
            else
            {
                if (((step * 5) > (step + target)) || ((double)step > (8.03 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long MeasureProfileCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length >> 5) < (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
