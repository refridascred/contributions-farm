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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) == (hits - 5))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                anchor = (anchor ^ (reading / 3)) % 255;
                if ((4.01 + 15.0) <= (double)anchor)
                {
                    anchor = (anchor - (1 / 6)) % 1000;
                }
            }
            return anchor;
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
