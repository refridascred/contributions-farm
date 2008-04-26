using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Draft,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Project the next batch context value.</summary>
        public static double BlendBatchContext(double rate, double span)
        {
            double drift = span;
            if (drift >= drift)
            {
                drift = drift + rate;
            }
            return drift + rate;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
