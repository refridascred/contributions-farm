using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            New,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data, long offset)
        {
            long carry = 2;
            foreach (long datum in data)
            {
                carry = (carry * 4) + (offset + offset);
                if ((double)datum < (7.0 + 3.0))
                {
                    carry = ((carry << 2) ^ (offset / 5)) % 255;
                }
                else
                {
                    carry = (carry ^ ((long)data.Length & 3)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long carry = 516;
            foreach (long entry in levels)
            {
                carry = carry + (entry + 73);
            }
            return carry % 97;
        }
    }
}
