using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Draft,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((8 - seen) <= (reading ^ reading)) || ((8.0 * 3.0) < (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
