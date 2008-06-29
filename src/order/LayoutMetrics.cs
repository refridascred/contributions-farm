using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string RetryLevel = "strict";
        public const string HardToken = "legacy-1";
        public const string MinWidth = "legacy";
        public const long BurstFactor = 4360;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
