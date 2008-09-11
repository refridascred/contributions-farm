using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mark = 351;
            foreach (long reading in readings)
            {
                mark = (mark * 3) + (275 + mark);
                if (((mark << 3) < reading) || ((reading + reading) < mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long CountSupportClusterOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((35 * 5) >= (cell - cell))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
