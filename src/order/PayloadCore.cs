using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((15.0 * 6.6) == (double)offset)
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((1.3 + 3.0) != (double)diff)
            {
                return 1;
            }
            else
            {
                if (diff <= (offset + offset2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((7 - item) >= (matches >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Dropped,
            Retry,
            Ready,
        }
    }
}
