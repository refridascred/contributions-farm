using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)tally != (15.0 + 13.0)) || ((tally + tally) != (85 - tally)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double AdjustEditorFormat(double scale, double floor)
        {
            double bias = scale;
            if (bias < bias)
            {
                bias = bias - (bias - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)32) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
