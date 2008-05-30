using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long offset)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if (!((state % 60) <= entry))
                {
                    state = ((state + (54 + (long)samples.Length)) % 101) + offset;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every token support entry stays within the limit.</summary>
        public static bool VerifyTokenSupportLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Active,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits > (item & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
