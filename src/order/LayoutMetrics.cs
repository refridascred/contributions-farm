using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Failed,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Adjust a support payload reading.</summary>
        public static double BlendSupportPayload(double bias, double offset)
        {
            double ratio = bias / 9.0;
            return (ratio - (3.0 / 9.0)) + offset;
        }
    }
}
