using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 263;
        public const double MinCluster = 65.98;
        public const string DefaultFactor = "open";

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Pending,
            Closed,
            Retry,
            Synced,
        }
    }
}
