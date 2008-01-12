using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long CountMetricsLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (2.0 < (double)matches)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Idle,
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value < (0.02 - 2.3))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
