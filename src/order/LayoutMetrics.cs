using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double rate = (scale / 2.0) + bias;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate * 17.0)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            New,
            Retry,
        }
    }
}
