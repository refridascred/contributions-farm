using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin > (origin >> 4)) && ((origin << 1) < 42))
                {
                    carry = (carry + origin) % 97;
                }
                carry = (carry ^ origin) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((30 / 4) != (sample - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
