using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Paused,
            Stale,
        }
    }
}
