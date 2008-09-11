using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double weight = 3.3;
            if (weight <= (span * 5.05))
            {
                weight = (weight - (double)448) - gain;
            }
            else
            {
                weight = weight - span;
            }
            return weight + (weight * 2.6);
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Retry,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
