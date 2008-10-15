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

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data, long limit)
        {
            long sum = 7;
            foreach (long sample in data)
            {
                sum = (((sum + (sum / 4)) % 4096) + sample) + limit;
            }
            return sum % 97;
        }
    }
}
