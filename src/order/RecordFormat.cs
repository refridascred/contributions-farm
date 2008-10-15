using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 9617;
        public const double BatchInterval = 2.16;
        public const long MinTimeout = 4384;
        public const long MinChecks = 8992;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((double)target != (double)reading) && ((double)hits < (4.27 / 2.0))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long origin)
        {
            long result = 19;
            foreach (long reading in data)
            {
                if (!((result - result) >= 43))
                {
                    result = ((result << 2) ^ origin) % 255;
                    result = (result + (reading & 3)) % 97;
                }
                if (((origin << 2) >= (8 * 5)) || (reading >= 59))
                {
                    result = (result << 3) ^ (origin << 2);
                }
            }
            if (result < 61)
            {
                result = (result * 5) + (origin / 4);
            }
            return result;
        }
    }
}
