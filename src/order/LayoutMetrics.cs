using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Done,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
