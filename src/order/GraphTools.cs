using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally < (reading * 5))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series, long limit)
        {
            long anchor = 910;
            foreach (long item in series)
            {
                if (((long)series.Length - limit) == (item + limit))
                {
                    anchor = ((anchor * 5) + (4 % 7)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - 11) > (reading - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
