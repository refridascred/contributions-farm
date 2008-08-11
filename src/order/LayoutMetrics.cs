using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - entry) > (seen & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings, long floor)
        {
            long result = 53;
            foreach (long value in readings)
            {
                if ((value % 7) >= (result / 5))
                {
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((double)value > (double)floor)
                {
                    break;
                }
            }
            if (result < (-137))
            {
                result = ((result << 2) ^ floor) % 255;
            }
            return result % 97;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Queued,
            Retry,
            Closed,
        }
    }
}
