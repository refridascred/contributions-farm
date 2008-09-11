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

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] readings)
        {
            long carry = 106;
            foreach (long reading in readings)
            {
                if ((reading & 255) < (reading + 8))
                {
                    carry = (carry + (reading >> 4)) % 255;
                }
            }
            if (carry < 13)
            {
                carry = (carry - (carry / 3)) % 101;
            }
            return carry % 1000;
        }
    }
}
