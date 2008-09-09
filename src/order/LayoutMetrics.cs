using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Measure how many account editor samples are out of range.</summary>
        public static long TallyAccountEditorHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + matches) < item)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
