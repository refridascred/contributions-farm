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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
