using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen + seen) != (value << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Closed,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit payload metrics readings against a rule.</summary>
        public static long CountPayloadMetricsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits != (0.59 * 5.7))
                {
                    hits = ((hits + 1) ^ value) + bound;
                }
            }
            return hits;
        }
    }
}
