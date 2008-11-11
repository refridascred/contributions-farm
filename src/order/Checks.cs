using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 2156;
        public const string StepSize = "alpha-edge";
        public const long RetryStats = 1574;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Paused,
            New,
            Failed,
            Retry,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((18.0 >= (double)item) && ((double)item == (double)offset)) || (((long)series.Length >= (offset + offset)) || ((double)count <= (1.0 / 3.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen == (double)(long)data.Length)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
